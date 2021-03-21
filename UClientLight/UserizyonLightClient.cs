using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UClient.Bindings;


namespace UClient
{
    /// <summary>
    /// TDLib client for using with generated APIs
    /// </summary>
    public class UserizyonLightClient : UApi.Client, IDisposable
    {
        private UJsonClient _tdJsonClient;
        
        private int _taskId;
        private readonly ConcurrentDictionary<int, Action<UApi.Object>> _tasks;
        
        private Receiver _receiver;
        private UApi.AuthorizationState _authorizationState;

        public UserizyonLightClient() : this(Interop.AutoDetectBindings()) {}

        public UserizyonLightClient(IULibBindings bindings)
        {
            _tdJsonClient = new UJsonClient(bindings);
            
            _tasks = new ConcurrentDictionary<int, Action<UApi.Object>>();
            
            _receiver = new Receiver(_tdJsonClient);
            _receiver.Received += OnReceived;
            _receiver.AuthorizationStateChanged += OnAuthorizationStateChanged;
            _receiver.Start();
        }

        public IULibBindings Bindings => _tdJsonClient.Bindings;

        /// <summary>
        /// How much time should wait for closed state
        /// </summary>
        public TimeSpan TimeoutToClose { get; set; } = TimeSpan.FromMinutes(1.0); 
        
        /// <summary>
        /// Provides updates from TDLib
        /// </summary>
        public event EventHandler<UApi.Update> UpdateReceived
        {
            add
            {
                lock (_updateLock)
                {
                    _updateReceived += value;
                    
                    while (_updateBuffer.TryDequeue(out var update))
                    {
                        _updateReceived(this, update);
                    }

                    _updateReceiverCount++;
                }
            }
            remove
            {
                lock (_updateLock)
                {
                    _updateReceived -= value;
                    _updateReceiverCount--;
                }
            }
        }

        private void OnReceived(object _, UApi.Object obj)
        {
            if (int.TryParse(obj.Extra, out int id) && _tasks.TryRemove(id, out var action))
            {
                action(obj);
            }
            else if (obj is UApi.Update update)
            {
                if (_updateReceiverCount == 0)
                {
                    _updateBuffer.Enqueue(update);
                }
                else
                {
                    _updateReceived(this, update);
                }
            }
        }

        private void OnAuthorizationStateChanged(object sender, UApi.AuthorizationState state)
        {
            _authorizationState = state;
        }

        private readonly object _disposeLock = new object();
        private readonly object _updateLock = new object();
        private readonly ConcurrentQueue<UApi.Update> _updateBuffer = new ConcurrentQueue<UApi.Update>();
        private EventHandler<UApi.Update> _updateReceived;
        private int _updateReceiverCount;
        
        /// <summary>
        /// Executes function and ignores response
        /// </summary>
        public override void Send<TResut>(UApi.Function<TResut> function)
        {
            if (_receiver == null)
            {
                throw new ObjectDisposedException("Userizyon client was disposed");
            }
            
            var data = JsonConvert.SerializeObject(function);
            _tdJsonClient.Send(data);
        }

        /// <summary>
        /// Synchronously executes function and returns response
        /// </summary>
        public override TResult Execute<TResult>(UApi.Function<TResult> function)
        {
            if (_receiver == null)
            {
                throw new ObjectDisposedException("Userizyon client was disposed");
            }
            
            var data = JsonConvert.SerializeObject(function);
            data = _tdJsonClient.Execute(data);
            var structure = JsonConvert.DeserializeObject<UApi.Object>(data, new Converter());
            
            if (structure is UApi.Error error)
            {
                throw new UException(error);
            }
            
            return (TResult)structure;
        }
        
        /// <summary>
        /// Asynchronously executes function and returns response
        /// </summary>
        public override Task<TResult> ExecuteAsync<TResult>(UApi.Function<TResult> function)
        {
            if (_receiver == null)
            {
                throw new ObjectDisposedException("Userizyon client was disposed");
            }
            
            var id = Interlocked.Increment(ref _taskId);
            var tcs = new TaskCompletionSource<TResult>(TaskCreationOptions.RunContinuationsAsynchronously);

            function.Extra = id.ToString();
            _tasks.TryAdd(id, structure =>
            {
                if (structure is UApi.Error error)
                {
                    tcs.SetException(new UException(error));
                }
                else if (structure is TResult result)
                {
                    tcs.SetResult(result);
                }
            });
            
            Send(function);
            
            return tcs.Task;
        }

        /// <summary>
        /// Disposes client and json client
        /// Updates are stopped from being sent to updates handler
        /// </summary>
        public void Dispose()
        {
            lock (_disposeLock)
            {
                if (_receiver == null || _tdJsonClient == null)
                {
                    return;
                }
            
                CloseSynchronously();
            
                _receiver.Dispose();
                _receiver.Received -= OnReceived;
                _receiver.AuthorizationStateChanged -= OnAuthorizationStateChanged;
                _receiver = null;
            
                _tdJsonClient.Dispose();
                _tdJsonClient = null;
            }
        }

        private async Task CloseAsync()
        {
            var tcs = new TaskCompletionSource<UApi.AuthorizationState>(TaskCreationOptions.RunContinuationsAsynchronously);

            EventHandler<UApi.AuthorizationState> handler = (sender, state) =>
            {
                if (state is UApi.AuthorizationState.AuthorizationStateClosed)
                {
                    tcs.SetResult(state);
                }
            };
            
            try
            {
                _receiver.AuthorizationStateChanged += handler;
                
                if (_authorizationState is UApi.AuthorizationState.AuthorizationStateClosed)
                {
                    return;
                }
                
                await ExecuteAsync(new UApi.Close());
                await Task.WhenAny(tcs.Task, Task.Delay(TimeoutToClose));
            }
            finally
            {
                _receiver.AuthorizationStateChanged -= handler;
            }
        }
        
        private void CloseSynchronously()
        {
            CloseAsync().GetAwaiter().GetResult();
        }
    }
}
using System;

using UClient.Bindings;

namespace UClient
{
    /// <summary>
    /// Plain text (JSON) client for TDLib
    /// </summary>
    public class UJsonClient : IDisposable
    {
        public IULibBindings Bindings { get; }
        private IntPtr _handle;

        public UJsonClient() : this(Interop.AutoDetectBindings()) {}
        
        public UJsonClient(IULibBindings bindings)
        {
            Bindings = bindings;
            _handle = Bindings.ClientCreate();
        }

        /// <summary>
        /// Send JSON to TDLib (ignores response if any provided)
        /// </summary>
        public void Send(string data)
        {
            if (_handle == IntPtr.Zero)
            {
                throw new ObjectDisposedException("UClient JSON client was disposed");
            }
            
          
            var ptr = Interop.StringToIntPtr(data);
            
            try
            {
                Bindings.ClientSend(_handle, ptr);
            }
            finally
            {
                Interop.FreeIntPtr(ptr);
            }
        }
        
        /// <summary>
        /// Receive one JSON string from TDLib
        /// </summary>
        public string Receive(double timeout)
        {
            if (_handle == IntPtr.Zero)
            {
                throw new ObjectDisposedException("UClient JSON client was disposed");
            }
            
            var res = Bindings.ClientReceive(_handle, timeout);
            return Interop.IntPtrToString(res);
        }

        /// <summary>
        /// Synchronously send JSON string to TDLib and get response 
        /// </summary>
        public string Execute(string data)
        {
            if (_handle == IntPtr.Zero)
            {
                throw new ObjectDisposedException("UClient JSON client was disposed");
            }
            
            var ptr = Interop.StringToIntPtr(data);

            try
            {
                var res = Bindings.ClientExecute(_handle, ptr);
                return Interop.IntPtrToString(res);
            }
            finally
            {
                Interop.FreeIntPtr(ptr);
            }
        }

        public void Dispose()
        {
            Destroy();
            GC.SuppressFinalize(this);
        }
        
        private void Destroy()
        {
            if (_handle == IntPtr.Zero)
            {
                return;
            }
            
            Bindings.ClientDestroy(_handle);
            _handle = IntPtr.Zero;
        }

        ~UJsonClient()
        {
            Destroy();
        }
    }
}
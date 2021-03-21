using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Creates a new call
        /// </summary>
        public class CreateCall : Function<CallId>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createCall";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of the user to be called
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// Description of the call protocols supported by the application
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("protocol")]
public CallProtocol Protocol { get; set; }

/// <summary>
/// True, if a video call needs to be created
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_video")]
public bool IsVideo { get; set; }


        }

        /// <summary>
        /// Creates a new call
        /// </summary>
        public static Task<CallId> CreateCallAsync(
            this Client client, int userId = default, CallProtocol protocol = default, bool isVideo = default)
        {
            return client.ExecuteAsync(new CreateCall
            {
                UserId = userId, Protocol = protocol, IsVideo = isVideo
            });
        }
    }
}

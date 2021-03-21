using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// A message failed to send. Be aware that some messages being sent can be irrecoverably deleted, in which case updateDeleteMessages will be received instead of this update
            /// </summary>
            public class UpdateMessageSendFailed : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateMessageSendFailed";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Contains information about the message which failed to send
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message")]
public Message Message { get; set; }

/// <summary>
/// The previous temporary message identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("old_message_id")]
public long OldMessageId { get; set; }

/// <summary>
/// An error code
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("error_code")]
public int ErrorCode { get; set; }

/// <summary>
/// Error message
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("error_message")]
public string ErrorMessage { get; set; }


            }
        }
    }
}
using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class NotificationType : Object
        {
            /// <summary>
            /// New call was received
            /// </summary>
            public class NotificationTypeNewCall : NotificationType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "notificationTypeNewCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Call identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("call_id")]
public int CallId { get; set; }


            }
        }
    }
}

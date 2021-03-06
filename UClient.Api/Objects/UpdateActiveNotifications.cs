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
            /// Contains active notifications that was shown on previous application launches. This update is sent only if the message database is used. In that case it comes once before any updateNotification and updateNotificationGroup update
            /// </summary>
            public class UpdateActiveNotifications : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateActiveNotifications";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Lists of active notification groups
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("groups")]
public NotificationGroup[] Groups { get; set; }


            }
        }
    }
}

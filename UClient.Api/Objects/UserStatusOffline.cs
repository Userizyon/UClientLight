using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class UserStatus : Object
        {
            /// <summary>
            /// The user is offline
            /// </summary>
            public class UserStatusOffline : UserStatus
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userStatusOffline";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when the user was last online
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("was_online")]
public int WasOnline { get; set; }


            }
        }
    }
}

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
            /// The user is online
            /// </summary>
            public class UserStatusOnline : UserStatus
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userStatusOnline";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when the user's online status will expire
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("expires")]
public int Expires { get; set; }


            }
        }
    }
}

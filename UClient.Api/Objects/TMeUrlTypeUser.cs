using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class TMeUrlType : Object
        {
            /// <summary>
            /// Describes the type of a URL linking to an internal Telegram entity
            /// </summary>
            public class TMeUrlTypeUser : TMeUrlType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "tMeUrlTypeUser";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Identifier of the user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }


            }
        }
    }
}

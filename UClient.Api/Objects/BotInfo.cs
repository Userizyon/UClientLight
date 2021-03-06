using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Provides information about a bot and its supported commands
        /// </summary>
        public partial class BotInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "botInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("description")]
public string Description { get; set; }

/// <summary>
/// A list of commands supported by the bot
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("commands")]
public BotCommand[] Commands { get; set; }


        }
    }
}

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
        /// Contains statistics about messages sent by a user
        /// </summary>
        public partial class ChatStatisticsMessageSenderInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "chatStatisticsMessageSenderInfo";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// User identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// Number of sent messages
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("sent_message_count")]
public int SentMessageCount { get; set; }

/// <summary>
/// Average number of characters in sent messages
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("average_character_count")]
public int AverageCharacterCount { get; set; }


        }
    }
}

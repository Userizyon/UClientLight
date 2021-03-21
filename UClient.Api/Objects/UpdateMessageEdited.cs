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
            /// A message was edited. Changes in the message content will come in a separate updateMessageContent
            /// </summary>
            public class UpdateMessageEdited : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateMessageEdited";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Chat identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// Message identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_id")]
public long MessageId { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when the message was edited
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("edit_date")]
public int EditDate { get; set; }

/// <summary>
/// New message reply markup; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("reply_markup")]
public ReplyMarkup ReplyMarkup { get; set; }


            }
        }
    }
}
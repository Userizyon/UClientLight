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
        /// Represents the results of the inline query. Use sendInlineQueryResultMessage to send the result of the query
        /// </summary>
        public partial class InlineQueryResults : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "inlineQueryResults";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Unique identifier of the inline query
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("inline_query_id")]
public long InlineQueryId { get; set; }

/// <summary>
/// The offset for the next request. If empty, there are no more results
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("next_offset")]
public string NextOffset { get; set; }

/// <summary>
/// Results of the query
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("results")]
public InlineQueryResult[] Results { get; set; }

/// <summary>
/// If non-empty, this text should be shown on the button, which opens a private chat with the bot and sends the bot a start message with the switch_pm_parameter
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("switch_pm_text")]
public string SwitchPmText { get; set; }

/// <summary>
/// Parameter for the bot start message
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("switch_pm_parameter")]
public string SwitchPmParameter { get; set; }


        }
    }
}
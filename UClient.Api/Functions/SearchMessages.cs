using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)).
        /// </summary>
        public class SearchMessages : Function<Messages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchMessages";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Chat list in which to search messages; pass null to search in all chats regardless of their chat list. Only Main and Archive chat lists are supported
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_list")]
public ChatList ChatList { get; set; }

/// <summary>
/// Query to search for
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("query")]
public string Query { get; set; }

/// <summary>
/// The date of the message starting from which the results should be fetched. Use 0 or any date in the future to get results from the last message
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("offset_date")]
public int OffsetDate { get; set; }

/// <summary>
/// The chat identifier of the last found message, or 0 for the first request
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("offset_chat_id")]
public long OffsetChatId { get; set; }

/// <summary>
/// The message identifier of the last found message, or 0 for the first request
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("offset_message_id")]
public long OffsetMessageId { get; set; }

/// <summary>
/// The maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("limit")]
public int Limit { get; set; }

/// <summary>
/// Filter for message content in the search results; searchMessagesFilterCall, searchMessagesFilterMissedCall, searchMessagesFilterMention, searchMessagesFilterUnreadMention, searchMessagesFilterFailedToSend and searchMessagesFilterPinned are unsupported in this function
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("filter")]
public SearchMessagesFilter Filter { get; set; }

/// <summary>
/// If not 0, the minimum date of the messages to return
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("min_date")]
public int MinDate { get; set; }

/// <summary>
/// If not 0, the maximum date of the messages to return
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("max_date")]
public int MaxDate { get; set; }


        }

        /// <summary>
        /// Searches for messages in all chats except secret chats. Returns the results in reverse chronological order (i.e., in order of decreasing (date, chat_id, message_id)).
        /// </summary>
        public static Task<Messages> SearchMessagesAsync(
            this Client client, ChatList chatList = default, string query = default, int offsetDate = default, long offsetChatId = default, long offsetMessageId = default, int limit = default, SearchMessagesFilter filter = default, int minDate = default, int maxDate = default)
        {
            return client.ExecuteAsync(new SearchMessages
            {
                ChatList = chatList, Query = query, OffsetDate = offsetDate, OffsetChatId = offsetChatId, OffsetMessageId = offsetMessageId, Limit = limit, Filter = filter, MinDate = minDate, MaxDate = maxDate
            });
        }
    }
}

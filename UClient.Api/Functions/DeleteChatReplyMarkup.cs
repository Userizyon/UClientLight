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
        /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
        /// </summary>
        public class DeleteChatReplyMarkup : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteChatReplyMarkup";

            /// <summary>
            /// Extra data attached to the function
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
/// The message identifier of the used keyboard
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_id")]
public long MessageId { get; set; }


        }

        /// <summary>
        /// Deletes the default reply markup from a chat. Must be called after a one-time keyboard or a ForceReply reply markup has been used. UpdateChatReplyMarkup will be sent if the reply markup will be changed
        /// </summary>
        public static Task<Ok> DeleteChatReplyMarkupAsync(
            this Client client, long chatId = default, long messageId = default)
        {
            return client.ExecuteAsync(new DeleteChatReplyMarkup
            {
                ChatId = chatId, MessageId = messageId
            });
        }
    }
}

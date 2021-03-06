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
        /// Returns list of user and chat, which can be used as aliases to join a voice chat in the chat
        /// </summary>
        public class GetAvailableVoiceChatAliases : Function<MessageSenders>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getAvailableVoiceChatAliases";

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


        }

        /// <summary>
        /// Returns list of user and chat, which can be used as aliases to join a voice chat in the chat
        /// </summary>
        public static Task<MessageSenders> GetAvailableVoiceChatAliasesAsync(
            this Client client, long chatId = default)
        {
            return client.ExecuteAsync(new GetAvailableVoiceChatAliases
            {
                ChatId = chatId
            });
        }
    }
}

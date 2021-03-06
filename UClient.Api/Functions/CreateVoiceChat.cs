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
        /// Creates a voice chat (a group call bound to a chat). Available only for basic groups, supergroups and channels; requires can_manage_voice_chats rights
        /// </summary>
        public class CreateVoiceChat : Function<GroupCallId>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createVoiceChat";

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
        /// Creates a voice chat (a group call bound to a chat). Available only for basic groups, supergroups and channels; requires can_manage_voice_chats rights
        /// </summary>
        public static Task<GroupCallId> CreateVoiceChatAsync(
            this Client client, long chatId = default)
        {
            return client.ExecuteAsync(new CreateVoiceChat
            {
                ChatId = chatId
            });
        }
    }
}

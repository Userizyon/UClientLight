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
        /// Changes the order of pinned chats
        /// </summary>
        public class SetPinnedChats : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setPinnedChats";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Chat list in which to change the order of pinned chats
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_list")]
public ChatList ChatList { get; set; }

/// <summary>
/// The new list of pinned chats
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_ids")]
public long[] ChatIds { get; set; }


        }

        /// <summary>
        /// Changes the order of pinned chats
        /// </summary>
        public static Task<Ok> SetPinnedChatsAsync(
            this Client client, ChatList chatList = default, long[] chatIds = default)
        {
            return client.ExecuteAsync(new SetPinnedChats
            {
                ChatList = chatList, ChatIds = chatIds
            });
        }
    }
}
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
            /// The number of online group members has changed. This update with non-zero count is sent only for currently opened chats. There is no guarantee that it will be sent just after the count has changed
            /// </summary>
            public class UpdateChatOnlineMemberCount : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatOnlineMemberCount";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Identifier of the chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_id")]
public long ChatId { get; set; }

/// <summary>
/// New number of online members in the chat, or 0 if unknown
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("online_member_count")]
public int OnlineMemberCount { get; set; }


            }
        }
    }
}

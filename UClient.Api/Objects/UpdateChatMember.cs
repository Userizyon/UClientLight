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
            /// User rights changed in a chat; for bots only
            /// </summary>
            public class UpdateChatMember : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatMember";

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
/// Identifier of the user, changing the rights
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("actor_user_id")]
public int ActorUserId { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when the user rights was changed
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("date")]
public int Date { get; set; }

/// <summary>
/// If user has joined the chat using an invite link, the invite link; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("invite_link")]
public ChatInviteLink InviteLink { get; set; }

/// <summary>
/// Previous chat member
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("old_chat_member")]
public ChatMember OldChatMember { get; set; }

/// <summary>
/// New chat member
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("new_chat_member")]
public ChatMember NewChatMember { get; set; }


            }
        }
    }
}

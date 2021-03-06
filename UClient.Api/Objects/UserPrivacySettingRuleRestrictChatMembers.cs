using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            /// <summary>
            /// A rule to restrict all members of specified basic groups and supergroups from doing something
            /// </summary>
            public class UserPrivacySettingRuleRestrictChatMembers : UserPrivacySettingRule
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleRestrictChatMembers";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The chat identifiers, total number of chats in all rules must not exceed 20
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_ids")]
public long[] ChatIds { get; set; }


            }
        }
    }
}

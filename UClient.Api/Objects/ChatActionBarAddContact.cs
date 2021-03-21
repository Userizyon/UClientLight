using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatActionBar : Object
        {
            /// <summary>
            /// The chat is a private or secret chat and the other user can be added to the contact list using the method addContact
            /// </summary>
            public class ChatActionBarAddContact : ChatActionBar
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatActionBarAddContact";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}
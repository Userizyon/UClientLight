using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatType : Object
        {
            /// <summary>
            /// A basic group (i.e., a chat with 0-200 other users)
            /// </summary>
            public class ChatTypeBasicGroup : ChatType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatTypeBasicGroup";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Basic group identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("basic_group_id")]
public int BasicGroupId { get; set; }


            }
        }
    }
}

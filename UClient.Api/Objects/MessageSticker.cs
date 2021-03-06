using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A sticker message
            /// </summary>
            public class MessageSticker : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageSticker";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The sticker description
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("sticker")]
public Sticker Sticker { get; set; }


            }
        }
    }
}

using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// The supergroup sticker set was changed
            /// </summary>
            public class ChatEventStickerSetChanged : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventStickerSetChanged";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Previous identifier of the chat sticker set; 0 if none
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("old_sticker_set_id")]
public long OldStickerSetId { get; set; }

/// <summary>
/// New identifier of the chat sticker set; 0 if none
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("new_sticker_set_id")]
public long NewStickerSetId { get; set; }


            }
        }
    }
}

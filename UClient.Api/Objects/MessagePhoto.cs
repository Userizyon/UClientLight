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
            /// A photo message
            /// </summary>
            public class MessagePhoto : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messagePhoto";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The photo description
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("photo")]
public Photo Photo { get; set; }

/// <summary>
/// Photo caption
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("caption")]
public FormattedText Caption { get; set; }

/// <summary>
/// True, if the photo must be blurred and must be shown only while tapped
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_secret")]
public bool IsSecret { get; set; }


            }
        }
    }
}

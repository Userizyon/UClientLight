using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Describes an animation file. The animation must be encoded in GIF or MPEG4 format
        /// </summary>
        public partial class Animation : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "animation";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Duration of the animation, in seconds; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("duration")]
public int Duration { get; set; }

/// <summary>
/// Width of the animation
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("width")]
public int Width { get; set; }

/// <summary>
/// Height of the animation
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("height")]
public int Height { get; set; }

/// <summary>
/// Original name of the file; as defined by the sender
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("file_name")]
public string FileName { get; set; }

/// <summary>
/// MIME type of the file, usually "image/gif" or "video/mp4"
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("mime_type")]
public string MimeType { get; set; }

/// <summary>
/// True, if stickers were added to the animation. The list of corresponding sticker set can be received using getAttachedStickerSets
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("has_stickers")]
public bool HasStickers { get; set; }

/// <summary>
/// Animation minithumbnail; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("minithumbnail")]
public Minithumbnail Minithumbnail { get; set; }

/// <summary>
/// Animation thumbnail in JPEG or MPEG4 format; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("thumbnail")]
public Thumbnail Thumbnail { get; set; }

/// <summary>
/// File containing the animation
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("animation")]
public File Animation_ { get; set; }


        }
    }
}
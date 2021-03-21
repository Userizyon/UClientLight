using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PageBlock : Object
        {
            /// <summary>
            /// The author and publishing date of a page
            /// </summary>
            public class PageBlockAuthorDate : PageBlock
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockAuthorDate";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Author
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("author")]
public RichText Author { get; set; }

/// <summary>
/// Point in time (Unix timestamp) when the article was published; 0 if unknown
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("publish_date")]
public int PublishDate { get; set; }


            }
        }
    }
}

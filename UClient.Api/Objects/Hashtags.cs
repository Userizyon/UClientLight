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
        /// Contains a list of hashtags
        /// </summary>
        public partial class Hashtags : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "hashtags";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// A list of hashtags
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("hashtags")]
public string[] Hashtags_ { get; set; }


        }
    }
}

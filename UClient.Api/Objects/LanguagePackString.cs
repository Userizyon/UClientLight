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
        /// Represents one language pack string
        /// </summary>
        public partial class LanguagePackString : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "languagePackString";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// String key
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("key")]
public string Key { get; set; }

/// <summary>
/// String value
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("value")]
public LanguagePackStringValue Value { get; set; }


        }
    }
}

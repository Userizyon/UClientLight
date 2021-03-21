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
        /// A simple object containing a vector of strings; for testing only
        /// </summary>
        public partial class TestVectorString : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "testVectorString";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Vector of strings
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("value")]
public string[] Value { get; set; }


        }
    }
}

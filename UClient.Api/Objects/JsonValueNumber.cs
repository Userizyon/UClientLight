using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class JsonValue : Object
        {
            /// <summary>
            /// Represents a numeric JSON value
            /// </summary>
            public class JsonValueNumber : JsonValue
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "jsonValueNumber";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The value
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("value")]
public double? Value { get; set; }


            }
        }
    }
}

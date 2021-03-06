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
            /// Represents a JSON object
            /// </summary>
            public class JsonValueObject : JsonValue
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "jsonValueObject";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The list of object members
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("members")]
public JsonObjectMember[] Members { get; set; }


            }
        }
    }
}

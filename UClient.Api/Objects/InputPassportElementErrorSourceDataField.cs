using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InputPassportElementErrorSource : Object
        {
            /// <summary>
            /// A data field contains an error. The error is considered resolved when the field's value changes
            /// </summary>
            public class InputPassportElementErrorSourceDataField : InputPassportElementErrorSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementErrorSourceDataField";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Field name
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("field_name")]
public string FieldName { get; set; }

/// <summary>
/// Current data hash
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("data_hash")]
public byte[] DataHash { get; set; }


            }
        }
    }
}

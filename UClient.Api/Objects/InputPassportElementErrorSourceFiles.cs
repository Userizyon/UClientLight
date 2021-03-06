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
            /// The list of attached files contains an error. The error is considered resolved when the file list changes
            /// </summary>
            public class InputPassportElementErrorSourceFiles : InputPassportElementErrorSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementErrorSourceFiles";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Current hashes of all attached files
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("file_hashes")]
public byte[][] FileHashes { get; set; }


            }
        }
    }
}

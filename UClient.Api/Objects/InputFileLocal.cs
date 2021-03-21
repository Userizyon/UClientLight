using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InputFile : Object
        {
            /// <summary>
            /// A file defined by a local path
            /// </summary>
            public class InputFileLocal : InputFile
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputFileLocal";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Local path to the file
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("path")]
public string Path { get; set; }


            }
        }
    }
}

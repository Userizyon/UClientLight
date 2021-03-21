using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// The file generation process needs to be started by the application
            /// </summary>
            public class UpdateFileGenerationStart : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateFileGenerationStart";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Unique identifier for the generation process
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("generation_id")]
public long GenerationId { get; set; }

/// <summary>
/// The path to a file from which a new file is generated; may be empty
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("original_path")]
public string OriginalPath { get; set; }

/// <summary>
/// The path to a file that should be created and where the new file should be generated
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("destination_path")]
public string DestinationPath { get; set; }

/// <summary>
/// String specifying the conversion applied to the original file. If conversion is "#url#" than original_path contains an HTTP/HTTPS URL of a file, which should be downloaded by the application
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("conversion")]
public string Conversion { get; set; }


            }
        }
    }
}
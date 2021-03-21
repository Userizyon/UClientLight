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
        /// Represents a local file
        /// </summary>
        public partial class LocalFile : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "localFile";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Local path to the locally available file part; may be empty
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("path")]
public string Path { get; set; }

/// <summary>
/// True, if it is possible to try to download or generate the file
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_downloaded")]
public bool CanBeDownloaded { get; set; }

/// <summary>
/// True, if the file can be deleted
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("can_be_deleted")]
public bool CanBeDeleted { get; set; }

/// <summary>
/// True, if the file is currently being downloaded (or a local copy is being generated by some other means)
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_downloading_active")]
public bool IsDownloadingActive { get; set; }

/// <summary>
/// True, if the local copy is fully available
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("is_downloading_completed")]
public bool IsDownloadingCompleted { get; set; }

/// <summary>
/// Download will be started from this offset. downloaded_prefix_size is calculated from this offset
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("download_offset")]
public int DownloadOffset { get; set; }

/// <summary>
/// If is_downloading_completed is false, then only some prefix of the file starting from download_offset is ready to be read. downloaded_prefix_size is the size of that prefix
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("downloaded_prefix_size")]
public int DownloadedPrefixSize { get; set; }

/// <summary>
/// Total downloaded file bytes. Should be used only for calculating download progress. The actual file size may be bigger, and some parts of it may contain garbage
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("downloaded_size")]
public int DownloadedSize { get; set; }


        }
    }
}
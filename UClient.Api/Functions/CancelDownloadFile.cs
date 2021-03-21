using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Stops the downloading of a file. If a file has already been downloaded, does nothing
        /// </summary>
        public class CancelDownloadFile : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "cancelDownloadFile";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifier of a file to stop downloading
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("file_id")]
public int FileId { get; set; }

/// <summary>
/// Pass true to stop downloading only if it hasn't been started, i.e. request hasn't been sent to server
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("only_if_pending")]
public bool OnlyIfPending { get; set; }


        }

        /// <summary>
        /// Stops the downloading of a file. If a file has already been downloaded, does nothing
        /// </summary>
        public static Task<Ok> CancelDownloadFileAsync(
            this Client client, int fileId = default, bool onlyIfPending = default)
        {
            return client.ExecuteAsync(new CancelDownloadFile
            {
                FileId = fileId, OnlyIfPending = onlyIfPending
            });
        }
    }
}
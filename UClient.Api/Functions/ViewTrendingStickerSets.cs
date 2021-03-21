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
        /// Informs the server that some trending sticker sets have been viewed by the user
        /// </summary>
        public class ViewTrendingStickerSets : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "viewTrendingStickerSets";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Identifiers of viewed trending sticker sets
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("sticker_set_ids")]
public long[] StickerSetIds { get; set; }


        }

        /// <summary>
        /// Informs the server that some trending sticker sets have been viewed by the user
        /// </summary>
        public static Task<Ok> ViewTrendingStickerSetsAsync(
            this Client client, long[] stickerSetIds = default)
        {
            return client.ExecuteAsync(new ViewTrendingStickerSets
            {
                StickerSetIds = stickerSetIds
            });
        }
    }
}

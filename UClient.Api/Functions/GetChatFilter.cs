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
        /// Returns information about a chat filter by its identifier
        /// </summary>
        public class GetChatFilter : Function<ChatFilter>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getChatFilter";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Chat filter identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("chat_filter_id")]
public int ChatFilterId { get; set; }


        }

        /// <summary>
        /// Returns information about a chat filter by its identifier
        /// </summary>
        public static Task<ChatFilter> GetChatFilterAsync(
            this Client client, int chatFilterId = default)
        {
            return client.ExecuteAsync(new GetChatFilter
            {
                ChatFilterId = chatFilterId
            });
        }
    }
}

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
        /// Edits existing chat filter. Returns information about the edited chat filter
        /// </summary>
        public class EditChatFilter : Function<ChatFilterInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "editChatFilter";

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

/// <summary>
/// The edited chat filter
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("filter")]
public ChatFilter Filter { get; set; }


        }

        /// <summary>
        /// Edits existing chat filter. Returns information about the edited chat filter
        /// </summary>
        public static Task<ChatFilterInfo> EditChatFilterAsync(
            this Client client, int chatFilterId = default, ChatFilter filter = default)
        {
            return client.ExecuteAsync(new EditChatFilter
            {
                ChatFilterId = chatFilterId, Filter = filter
            });
        }
    }
}

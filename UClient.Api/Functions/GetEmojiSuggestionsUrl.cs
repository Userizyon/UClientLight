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
        /// Returns an HTTP URL which can be used to automatically log in to the translation platform and suggest new emoji replacements. The URL will be valid for 30 seconds after generation
        /// </summary>
        public class GetEmojiSuggestionsUrl : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getEmojiSuggestionsUrl";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Language code for which the emoji replacements will be suggested
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("language_code")]
public string LanguageCode { get; set; }


        }

        /// <summary>
        /// Returns an HTTP URL which can be used to automatically log in to the translation platform and suggest new emoji replacements. The URL will be valid for 30 seconds after generation
        /// </summary>
        public static Task<HttpUrl> GetEmojiSuggestionsUrlAsync(
            this Client client, string languageCode = default)
        {
            return client.ExecuteAsync(new GetEmojiSuggestionsUrl
            {
                LanguageCode = languageCode
            });
        }
    }
}

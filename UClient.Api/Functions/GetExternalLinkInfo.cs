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
        /// Returns information about an action to be done when the current user clicks an HTTP link. This method can be used to automatically authorize the current user on a website
        /// </summary>
        public class GetExternalLinkInfo : Function<LoginUrlInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getExternalLinkInfo";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// The HTTP link
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("link")]
public string Link { get; set; }


        }

        /// <summary>
        /// Returns information about an action to be done when the current user clicks an HTTP link. This method can be used to automatically authorize the current user on a website
        /// </summary>
        public static Task<LoginUrlInfo> GetExternalLinkInfoAsync(
            this Client client, string link = default)
        {
            return client.ExecuteAsync(new GetExternalLinkInfo
            {
                Link = link
            });
        }
    }
}

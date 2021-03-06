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
        /// Returns backgrounds installed by the user
        /// </summary>
        public class GetBackgrounds : Function<Backgrounds>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getBackgrounds";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// True, if the backgrounds must be ordered for dark theme
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("for_dark_theme")]
public bool ForDarkTheme { get; set; }


        }

        /// <summary>
        /// Returns backgrounds installed by the user
        /// </summary>
        public static Task<Backgrounds> GetBackgroundsAsync(
            this Client client, bool forDarkTheme = default)
        {
            return client.ExecuteAsync(new GetBackgrounds
            {
                ForDarkTheme = forDarkTheme
            });
        }
    }
}

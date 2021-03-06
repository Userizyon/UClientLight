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
        /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
        /// </summary>
        public class GetOption : Function<OptionValue>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getOption";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// The name of the option
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("name")]
public string Name { get; set; }


        }

        /// <summary>
        /// Returns the value of an option by its name. (Check the list of available options on https://core.telegram.org/tdlib/options.) Can be called before authorization
        /// </summary>
        public static Task<OptionValue> GetOptionAsync(
            this Client client, string name = default)
        {
            return client.ExecuteAsync(new GetOption
            {
                Name = name
            });
        }
    }
}

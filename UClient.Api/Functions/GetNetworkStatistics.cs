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
        /// Returns network data usage statistics. Can be called before authorization
        /// </summary>
        public class GetNetworkStatistics : Function<NetworkStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getNetworkStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// If true, returns only data for the current library launch
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("only_current")]
public bool OnlyCurrent { get; set; }


        }

        /// <summary>
        /// Returns network data usage statistics. Can be called before authorization
        /// </summary>
        public static Task<NetworkStatistics> GetNetworkStatisticsAsync(
            this Client client, bool onlyCurrent = default)
        {
            return client.ExecuteAsync(new GetNetworkStatistics
            {
                OnlyCurrent = onlyCurrent
            });
        }
    }
}

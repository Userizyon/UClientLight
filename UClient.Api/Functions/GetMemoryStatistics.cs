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
        /// Returns memory statistics
        /// </summary>
        public class GetMemoryStatistics : Function<MemoryStatistics>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getMemoryStatistics";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Full memory statistics calculation
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("full")]
public bool Full { get; set; }


        }

        /// <summary>
        /// Returns memory statistics
        /// </summary>
        public static Task<MemoryStatistics> GetMemoryStatisticsAsync(
            this Client client, bool full = default)
        {
            return client.ExecuteAsync(new GetMemoryStatistics
            {
                Full = full
            });
        }
    }
}

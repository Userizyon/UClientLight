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
        /// Optimize memory
        /// </summary>
        public class OptimizeMemory : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "optimizeMemory";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Full memory optimization
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("full")]
public bool Full { get; set; }


        }

        /// <summary>
        /// Optimize memory
        /// </summary>
        public static Task<Ok> OptimizeMemoryAsync(
            this Client client, bool full = default)
        {
            return client.ExecuteAsync(new OptimizeMemory
            {
                Full = full
            });
        }
    }
}

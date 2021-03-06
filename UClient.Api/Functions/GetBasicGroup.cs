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
        /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public class GetBasicGroup : Function<BasicGroup>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getBasicGroup";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Basic group identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("basic_group_id")]
public int BasicGroupId { get; set; }


        }

        /// <summary>
        /// Returns information about a basic group by its identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public static Task<BasicGroup> GetBasicGroupAsync(
            this Client client, int basicGroupId = default)
        {
            return client.ExecuteAsync(new GetBasicGroup
            {
                BasicGroupId = basicGroupId
            });
        }
    }
}

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
        /// Returns information about a group call
        /// </summary>
        public class GetGroupCall : Function<GroupCall>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getGroupCall";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Group call identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("group_call_id")]
public int GroupCallId { get; set; }


        }

        /// <summary>
        /// Returns information about a group call
        /// </summary>
        public static Task<GroupCall> GetGroupCallAsync(
            this Client client, int groupCallId = default)
        {
            return client.ExecuteAsync(new GetGroupCall
            {
                GroupCallId = groupCallId
            });
        }
    }
}
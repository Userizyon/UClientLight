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
        /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        public class ReportSupergroupSpam : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "reportSupergroupSpam";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Supergroup identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("supergroup_id")]
public int SupergroupId { get; set; }

/// <summary>
/// User identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// Identifiers of messages sent in the supergroup by the user. This list must be non-empty
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("message_ids")]
public long[] MessageIds { get; set; }


        }

        /// <summary>
        /// Reports some messages from a user in a supergroup as spam; requires administrator rights in the supergroup
        /// </summary>
        public static Task<Ok> ReportSupergroupSpamAsync(
            this Client client, int supergroupId = default, int userId = default, long[] messageIds = default)
        {
            return client.ExecuteAsync(new ReportSupergroupSpam
            {
                SupergroupId = supergroupId, UserId = userId, MessageIds = messageIds
            });
        }
    }
}

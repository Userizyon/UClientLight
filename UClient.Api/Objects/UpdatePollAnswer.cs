using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class Update : Object
        {
            /// <summary>
            /// A user changed the answer to a poll; for bots only
            /// </summary>
            public class UpdatePollAnswer : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updatePollAnswer";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Unique poll identifier
/// </summary>
[JsonConverter(typeof(Converter.Int64))]
[JsonProperty("poll_id")]
public long PollId { get; set; }

/// <summary>
/// The user, who changed the answer to the poll
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }

/// <summary>
/// 0-based identifiers of answer options, chosen by the user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("option_ids")]
public int[] OptionIds { get; set; }


            }
        }
    }
}

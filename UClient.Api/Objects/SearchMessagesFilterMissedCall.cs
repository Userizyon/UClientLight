using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class SearchMessagesFilter : Object
        {
            /// <summary>
            /// Returns only incoming call messages with missed/declined discard reasons
            /// </summary>
            public class SearchMessagesFilterMissedCall : SearchMessagesFilter
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "searchMessagesFilterMissedCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}

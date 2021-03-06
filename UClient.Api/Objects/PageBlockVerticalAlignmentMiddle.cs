using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PageBlockVerticalAlignment : Object
        {
            /// <summary>
            /// The content should be middle-aligned
            /// </summary>
            public class PageBlockVerticalAlignmentMiddle : PageBlockVerticalAlignment
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockVerticalAlignmentMiddle";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }


            }
        }
    }
}

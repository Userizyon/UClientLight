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
            /// The selected background has changed
            /// </summary>
            public class UpdateSelectedBackground : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSelectedBackground";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// True, if background for dark theme has changed
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("for_dark_theme")]
public bool ForDarkTheme { get; set; }

/// <summary>
/// The new selected background; may be null
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("background")]
public Background Background { get; set; }


            }
        }
    }
}

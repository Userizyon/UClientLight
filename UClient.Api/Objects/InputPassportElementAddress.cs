using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class InputPassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element to be saved containing the user's address
            /// </summary>
            public class InputPassportElementAddress : InputPassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementAddress";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// The address to be saved
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("address")]
public Address Address { get; set; }


            }
        }
    }
}

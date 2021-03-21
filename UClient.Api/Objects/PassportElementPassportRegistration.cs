using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        public partial class PassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element containing the user's passport registration pages
            /// </summary>
            public class PassportElementPassportRegistration : PassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementPassportRegistration";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Passport registration pages
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("passport_registration")]
public PersonalDocument PassportRegistration { get; set; }


            }
        }
    }
}
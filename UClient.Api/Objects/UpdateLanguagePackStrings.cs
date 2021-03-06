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
            /// Some language pack strings have been updated
            /// </summary>
            public class UpdateLanguagePackStrings : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateLanguagePackStrings";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// Localization target to which the language pack belongs
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("localization_target")]
public string LocalizationTarget { get; set; }

/// <summary>
/// Identifier of the updated language pack
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("language_pack_id")]
public string LanguagePackId { get; set; }

/// <summary>
/// List of changed language pack strings
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("strings")]
public LanguagePackString[] Strings { get; set; }


            }
        }
    }
}

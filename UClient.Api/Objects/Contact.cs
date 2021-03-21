using System;
using Newtonsoft.Json;

namespace UClient
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class UApi
    {
        /// <summary>
        /// Describes a user contact
        /// </summary>
        public partial class Contact : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "contact";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Phone number of the user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("phone_number")]
public string PhoneNumber { get; set; }

/// <summary>
/// First name of the user; 1-255 characters in length
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("first_name")]
public string FirstName { get; set; }

/// <summary>
/// Last name of the user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("last_name")]
public string LastName { get; set; }

/// <summary>
/// Additional data about the user in a form of vCard; 0-2048 bytes in length
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("vcard")]
public string Vcard { get; set; }

/// <summary>
/// Identifier of the user, if known; otherwise 0
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }


        }
    }
}

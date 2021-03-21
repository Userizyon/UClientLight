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
        /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
        /// </summary>
        public class SetPassportElement : Function<PassportElement>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setPassportElement";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Input Telegram Passport element
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("element")]
public InputPassportElement Element { get; set; }

/// <summary>
/// Password of the current user
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("password")]
public string Password { get; set; }


        }

        /// <summary>
        /// Adds an element to the user's Telegram Passport. May return an error with a message "PHONE_VERIFICATION_NEEDED" or "EMAIL_VERIFICATION_NEEDED" if the chosen phone number or the chosen email address must be verified first
        /// </summary>
        public static Task<PassportElement> SetPassportElementAsync(
            this Client client, InputPassportElement element = default, string password = default)
        {
            return client.ExecuteAsync(new SetPassportElement
            {
                Element = element, Password = password
            });
        }
    }
}

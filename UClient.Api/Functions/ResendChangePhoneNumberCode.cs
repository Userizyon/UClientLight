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
        /// Re-sends the authentication code sent to confirm a new phone number for the user. Works only if the previously received authenticationCodeInfo next_code_type was not null
        /// </summary>
        public class ResendChangePhoneNumberCode : Function<AuthenticationCodeInfo>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "resendChangePhoneNumberCode";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            

        }

        /// <summary>
        /// Re-sends the authentication code sent to confirm a new phone number for the user. Works only if the previously received authenticationCodeInfo next_code_type was not null
        /// </summary>
        public static Task<AuthenticationCodeInfo> ResendChangePhoneNumberCodeAsync(
            this Client client)
        {
            return client.ExecuteAsync(new ResendChangePhoneNumberCode
            {
                
            });
        }
    }
}

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
        /// Recovers the password using a recovery code sent to an email address that was previously set up
        /// </summary>
        public class RecoverPassword : Function<PasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "recoverPassword";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// Recovery code to check
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("recovery_code")]
public string RecoveryCode { get; set; }


        }

        /// <summary>
        /// Recovers the password using a recovery code sent to an email address that was previously set up
        /// </summary>
        public static Task<PasswordState> RecoverPasswordAsync(
            this Client client, string recoveryCode = default)
        {
            return client.ExecuteAsync(new RecoverPassword
            {
                RecoveryCode = recoveryCode
            });
        }
    }
}

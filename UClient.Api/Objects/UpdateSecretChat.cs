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
            /// Some data of a secret chat has changed. This update is guaranteed to come before the secret chat identifier is returned to the application
            /// </summary>
            public class UpdateSecretChat : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateSecretChat";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

/// <summary>
/// New data about the secret chat
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("secret_chat")]
public SecretChat SecretChat { get; set; }


            }
        }
    }
}

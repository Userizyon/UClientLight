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
        /// Stripe payment provider
        /// </summary>
        public partial class PaymentsProviderStripe : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "paymentsProviderStripe";

            /// <summary>
            /// Extra data attached to the object
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

/// <summary>
/// Stripe API publishable key
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("publishable_key")]
public string PublishableKey { get; set; }

/// <summary>
/// True, if the user country must be provided
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("need_country")]
public bool NeedCountry { get; set; }

/// <summary>
/// True, if the user ZIP/postal code must be provided
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("need_postal_code")]
public bool NeedPostalCode { get; set; }

/// <summary>
/// True, if the cardholder name must be provided
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("need_cardholder_name")]
public bool NeedCardholderName { get; set; }


        }
    }
}

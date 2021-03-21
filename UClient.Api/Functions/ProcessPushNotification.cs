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
        /// Handles a push notification. Returns error with code 406 if the push notification is not supported and connection to the server is required to fetch new data. Can be called before authorization
        /// </summary>
        public class ProcessPushNotification : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "processPushNotification";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// JSON-encoded push notification payload with all fields sent by the server, and "google.sent_time" and "google.notification.sound" fields added
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("payload")]
public string Payload { get; set; }


        }

        /// <summary>
        /// Handles a push notification. Returns error with code 406 if the push notification is not supported and connection to the server is required to fetch new data. Can be called before authorization
        /// </summary>
        public static Task<Ok> ProcessPushNotificationAsync(
            this Client client, string payload = default)
        {
            return client.ExecuteAsync(new ProcessPushNotification
            {
                Payload = payload
            });
        }
    }
}

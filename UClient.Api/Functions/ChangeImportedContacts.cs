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
        /// Changes imported contacts using the list of contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts.
        /// </summary>
        public class ChangeImportedContacts : Function<ImportedContacts>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "changeImportedContacts";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("contacts")]
public Contact[] Contacts { get; set; }


        }

        /// <summary>
        /// Changes imported contacts using the list of contacts saved on the device. Imports newly added contacts and, if at least the file database is enabled, deletes recently deleted contacts.
        /// </summary>
        public static Task<ImportedContacts> ChangeImportedContactsAsync(
            this Client client, Contact[] contacts = default)
        {
            return client.ExecuteAsync(new ChangeImportedContacts
            {
                Contacts = contacts
            });
        }
    }
}

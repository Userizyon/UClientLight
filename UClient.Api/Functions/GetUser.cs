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
        /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public class GetUser : Function<User>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getUser";

            /// <summary>
            /// Extra data attached to the function
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }
            
/// <summary>
/// User identifier
/// </summary>
[JsonConverter(typeof(Converter))]
[JsonProperty("user_id")]
public int UserId { get; set; }


        }

        /// <summary>
        /// Returns information about a user by their identifier. This is an offline request if the current user is not a bot
        /// </summary>
        public static Task<User> GetUserAsync(
            this Client client, int userId = default)
        {
            return client.ExecuteAsync(new GetUser
            {
                UserId = userId
            });
        }
    }
}

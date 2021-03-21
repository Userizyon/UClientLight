using Newtonsoft.Json;

namespace UClient
{
    public static partial class UApi
    {
        /// <summary>
        /// Base class for all objects
        /// </summary>
        public abstract class Object
        {
            [JsonProperty("@type")] public virtual string DataType { get; set; }

            [JsonProperty("@extra")] public virtual string Extra { get; set; }
        }
    }
}
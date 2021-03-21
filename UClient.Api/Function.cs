using System.Threading.Tasks;

namespace UClient
{
    public static partial class UApi
    {
        /// <summary>
        /// Base class for all functions
        /// </summary>
        /// <typeparam name="T">Return type for this function</typeparam>
        public abstract class Function<T> : Object
        {
        }
    }
}
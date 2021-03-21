using System;


namespace UClient
{
    /// <summary>
    /// Exception used to signal that TDLib returned an error
    /// </summary>
    public class UException : Exception
    {
        public readonly UApi.Error Error;

        public UException(UApi.Error error) : base(error.Message)
        {
            Error = error;
        }
    }
}
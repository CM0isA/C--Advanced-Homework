using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class NonExistentConnectionException : Exception
    {
        public NonExistentConnectionException()
        {
           
        }

        public NonExistentConnectionException(string message) : base(message)
        {
        }

        public NonExistentConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NonExistentConnectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
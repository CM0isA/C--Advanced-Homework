using System;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    internal class DummyDatabaseConnectionException : Exception
    {
        public DummyDatabaseConnectionException()
        {
        }

        public DummyDatabaseConnectionException(string message) : base(message)
        {
        }

        public DummyDatabaseConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DummyDatabaseConnectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
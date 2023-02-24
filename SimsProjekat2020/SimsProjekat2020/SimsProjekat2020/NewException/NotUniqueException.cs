using System;
using System.Runtime.Serialization;

namespace SimsProjekat2020.Repository
{
    [Serializable]
    internal class NotUniqueException : Exception
    {
        public NotUniqueException()
        {
        }

        public NotUniqueException(string message) : base(message)
        {
        }

        public NotUniqueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotUniqueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Runtime.Serialization;

namespace AlbionAssistant
{
    [Serializable]
    internal class InputIsNotAnIntegerException : Exception
    {
        public InputIsNotAnIntegerException()
        {
        }

        public InputIsNotAnIntegerException(string message) : base(message)
        {
        }

        public InputIsNotAnIntegerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InputIsNotAnIntegerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
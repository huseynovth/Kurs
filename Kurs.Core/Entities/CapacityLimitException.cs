using System.Runtime.Serialization;

namespace Kurs.Core.Entities
{
   
     public class CapacityLimitException : Exception
    {
        public CapacityLimitException()
        {
        }

        public CapacityLimitException(string? message) : base(message)
        {
        }

        public CapacityLimitException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CapacityLimitException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
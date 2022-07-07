using System;
using System.Runtime.Serialization;

namespace Bank
{
    class Bankrut : Exception
    {
        public DateTime TimeException { get; private set; }
        public Bankrut() : this("You is bankrut")
        {
            TimeException = DateTime.Now;
        }

        public Bankrut(string message) : base(message)
        {
        }

        public Bankrut(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected Bankrut(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

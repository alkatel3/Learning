using System;

namespace Exception01
{
    class RangeArrayException : Exception
    {
        public RangeArrayException() : base() { }
        public RangeArrayException(string str) : base(str) { }
        public RangeArrayException(
            string str, Exception inner) : base(str, inner) { }
        protected RangeArrayException(
            System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext st):
            base(si, st) { }

        public override string ToString()
        {
            return Message;
        }
    }
    
}
using System;

namespace Interface
{
    class PErson : ICloneable
    {
        public string Name { get; set; }
        public int age { get; set; }
       
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

using System;

namespace Interfaces
{
    class StudentCard
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public override string ToString()
        {
            return $"Student card: {Series} {Number}";
        }
    }
}

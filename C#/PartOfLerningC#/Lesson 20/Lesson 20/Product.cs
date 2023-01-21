using System;


namespace Lesson_20
{
    class Product
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public override string ToString()
        {
            return $"{Name}({Energy})";
        }

        internal static object GroupBy()
        {
            throw new NotImplementedException();
        }
    }
}

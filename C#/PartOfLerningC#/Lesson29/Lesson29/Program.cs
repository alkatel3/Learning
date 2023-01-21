using System;

namespace Lesson29
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new object();
            int i = 4;
            int j = 4;
            Console.WriteLine(i.Equals(j));
            object oi = i ;
            object oj = j;
            Console.WriteLine(oi.Equals(oj));
            var p1 = new Point() { X = 4 };
            var p2 = new Point() { X = 4 };
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(i.ToString());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(i.GetType());
            Console.WriteLine(oi.GetType());
            Console.WriteLine(typeof(Point) == p1.GetType());
            Console.WriteLine(p1.GetType());

            Console.WriteLine(Object.Equals(5, 5));
            Console.WriteLine(Object.ReferenceEquals(5,5));
            Console.WriteLine( Object.ReferenceEquals(p2,p2));
        }
    }
}

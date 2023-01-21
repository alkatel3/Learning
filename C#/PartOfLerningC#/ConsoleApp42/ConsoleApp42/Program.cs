using System;

namespace ConsoleApp42
{
    class Counter 
    { 
        public int Value { get; set; }
        public static Counter operator +(Counter c1,Counter c2 )
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static bool operator > (Counter c1,Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator < (Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;

        }
        public static int operator +(Counter c1,int a)
        {
            return c1. Value + a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 33 };
            bool result = c1 > c2;
            Counter c3 = c1 + c2;
            int d = c1 + 27;
            Console.WriteLine($"{result}\n{c3.Value}\n{d}");
            
        }
    }
}

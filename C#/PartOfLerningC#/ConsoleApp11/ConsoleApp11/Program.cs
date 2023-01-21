using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine($"{a} before metod");

            incremen(a);
            Console.WriteLine($"{a} after first metod");
            increment(ref a);
            Console.WriteLine($"{a} after second metod");
        }
        static void increment (ref int x)
        {
            x++;
            Console.WriteLine($"{x} in increment");
           
        }
        static void incremen(int x)
        {
            x++;
            Console.WriteLine($"{x} in incremen");
        }

    }
}

using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("input a");
                var a = Console.ReadLine();
                Console.WriteLine("input b");
                var b = Console.ReadLine();
                Console.WriteLine("input c");
                var c = Console.ReadLine();
                if (int.TryParse(a, out int a1) && int.TryParse(b, out int b1) && int.TryParse(c, out int c1))
                {
                    Console.WriteLine($" a+b={a1 + b1}\n a+b-c={a1 + b1 - c1}\n  a-b-c={a1 - b1 - c1}");
                    break;
                }
                else
                {
                    Console.WriteLine("a, b, c mast have type int");
                }
     
            }
           
        }
    }
} 

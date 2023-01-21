using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = (5, 6);
            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);
            a.Item1 += 6;
            Console.WriteLine(a.Item1);

        }
    }
}

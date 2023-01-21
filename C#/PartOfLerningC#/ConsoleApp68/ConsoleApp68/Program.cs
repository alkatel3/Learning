using System;

namespace ConsoleApp68
{
    delegate int MATH(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(increment(new Random().Next(1, 10)));
            MATH max = (int a, int b) => (a > b ? a : b);
            MATH sum = (int a, int b) => { return a + b; };
            Console.WriteLine(max(5,10));
            Console.WriteLine(sum(5, 10));
        }
        static int increment(int number)
        {
            return number + 1;
        }
    }
}

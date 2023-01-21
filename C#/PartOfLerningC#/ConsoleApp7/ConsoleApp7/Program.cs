using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 15;
            int Result = sum(x, y);
            int result = sum(15, 23);
            Console.WriteLine($"{Result} or {result}");
        }
        static int sum(int a,int b)
        {
            return a + b;
        }
    }
}

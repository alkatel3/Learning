using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            sum( a, b, out int P, out int S);
            Console.WriteLine($"P={P}\nS={S}");
        }
        static void sum (in int x, int y, out int P,out int S)
        {
           // x+=10; - помилка
            y += 10;
            P = (x + y) * 2;
            S = x * y;
        }
    }
}

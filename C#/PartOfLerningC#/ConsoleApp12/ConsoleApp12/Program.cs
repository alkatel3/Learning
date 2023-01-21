using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("сторони прямокутника:");
            Console.Write("b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("a:");
            int a = Convert.ToInt32(Console.ReadLine());
            int P;
            int S;
            sum(a, b, out P,out S);
            Console.WriteLine($"P={P}\nS={S}");
        }
        static void sum (int x,int y, out int P, out int S)
        {
            P = (x + y)*2;
            S = x * y;
        }
    }
}

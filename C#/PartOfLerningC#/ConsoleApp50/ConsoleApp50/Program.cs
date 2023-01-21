using System;
namespace App50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first namber:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second namber:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third namber:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"a={a}\nb={b}\nc={c}");
            if (a > b && a > c)
                Console.WriteLine($"{a} is the most");
            else if (c > a && c > b)
                Console.WriteLine($"{c} is the most");
            else
                Console.WriteLine($"{b} is the most");

            switch (a % 2)
            {
                case (1):
                    Console.WriteLine("a%2=1");
                    break;
                default:
                    Console.WriteLine("a%2=0");
                    break;

            }
            switch (b % 2)
            {
                case (1):
                    Console.WriteLine("b%2=1");
                    break;
                default:
                    Console.WriteLine("b%2=0");
                    break;

            }
            switch (c % 2)
            {
                case (1):
                    Console.WriteLine("c%2=1");
                    break;
                default:
                    Console.WriteLine("c%2=0");
                    break;
                    

            }
            string d = a > 100 ? "yes" : "no";
                    string e = b > 100 ? "yes" : "no";
                    string f = c > 100 ? "yes" : "no";
                    Console.WriteLine($"Is a the most then 100?\n{d}\nIs b the most then 100?\n{e}\nIs c the most then 100?\n{f}\n");
        }
    }
}
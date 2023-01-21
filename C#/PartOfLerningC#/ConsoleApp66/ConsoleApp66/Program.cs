using System;


namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Cos(2 * x);
            Console.WriteLine($"y={y}");
        }
    }
}

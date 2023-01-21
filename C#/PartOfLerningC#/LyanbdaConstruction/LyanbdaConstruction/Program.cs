using static System.Console;
using System;

namespace LyanbdaConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleCalc calc = new();

            WriteLine(calc.CurrentDate);
            try
            {
                Write("Enter an integer: ");
                int n1 = Int32.Parse(ReadLine());

                Write("Enter an integer: ");
                int n2 = Int32.Parse(ReadLine());

                WriteLine($"{n1} + {n2} = {calc.AddInt(n1, n2)}");
                ExampleCalc.AddVoid(n1, n2);
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}

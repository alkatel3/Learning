using System;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
           
            {
                for (int i = 0; i >= 0; i++)
                {
                    Console.WriteLine("Input x (int)");
                    int x;
                    var input = Console.ReadLine();
                    if (Int32.TryParse(input, out x))
                    {
                        Console.WriteLine($"x^2={x * x}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input element type int");
                        continue;
                    }
                    Console.ReadKey();
                }
            }

           
        }
    }
}

using System;
using static System.Math;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {


            for (; ; )
            {
                Console.WriteLine("Input x");
                var x = Console.ReadLine();
                if (double.TryParse(x, out double x1))
                {


                    double y = Cos(2 * x1);


                    Console.WriteLine("cos(2*{0})={1:F10}", x1, y);
                    Console.WriteLine("{0:F10}\n{1:F10}", Pow(Sin(x1), 2), Pow(Cos(x1), 2));
                    double y1 = Pow(Sin(x1), 2) + Pow(Cos(x1), 2);
                    Console.WriteLine("cos^2({0})+sin^2({0})={1:F10}", x1, y1);
                    Console.WriteLine("Input a");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Pow(x1, 1.0/3.0));
                    Console.WriteLine(Exp(Tan(Pow(x1, a))));
                    Console.WriteLine(Pow(x1, 4 * PI));

                    double y2 = Pow(x1, 1.0/3.0) + Exp(Tan(Pow(x1, a))) + Pow(x1, 4 * PI);
                 
                    Console.WriteLine("{0}^(1.0/3.0)+e^tg({0}^{1})+({0}^4PI)={2}",x,a,y2);
                    break;
                }
                else
                {
                    Console.WriteLine("Не коректне введення");
                    continue;
                }
            }

        }
    }
}


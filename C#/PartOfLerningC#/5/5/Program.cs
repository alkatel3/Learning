using System;
using static System.Math;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                double a;
                double R1;
                double R2;
                double S;
                Console.WriteLine("виберіть вимір трикутника який ви хочете задати цифрою вд 1 до 4, якщo:");
                Console.WriteLine("1 – сторона a");
                Console.WriteLine("2 – радіус R1 вписаного кола");
                Console.WriteLine("3 – радіус R2 описаного кола");
                Console.WriteLine("4 – площа S");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("введіть довжину сторони a");
                        a = Convert.ToDouble(Console.ReadLine());
                        R2 = a / Sqrt(3.0);
                        R1 = R2 / 2.0;
                        S = Pow(a, 2) * Sqrt(3.0) / 4.0;
                        Console.WriteLine($"{a}\n{R2}\n{R1}\n{S}");
                        break;
                    case "2":
                        Console.WriteLine("введіть довжину R1 вписаного кола");
                        R1 = Convert.ToDouble(Console.ReadLine());
                        R2 = 2 * R1;
                        a = R2 * Sqrt(3.0);
                        S = Pow(a, 2) * Sqrt(3.0) / 4.0;
                        Console.WriteLine($"{a}\n{R2}\n{R1}\n{S}");
                        break;
                    case "3":
                        Console.WriteLine("введіть довжину R2 описаного кола");
                        R2 = Convert.ToDouble(Console.ReadLine());
                        R1 = R2 / 2.0;
                        a = R2 * Sqrt(3.0);
                        S = Pow(a, 2) * Sqrt(3.0) / 4.0;
                        Console.WriteLine($"{a}\n{R2}\n{R1}\n{S}");
                        break;
                    case "4":
                        Console.WriteLine("введіть площу S");
                        S = Convert.ToDouble(Console.ReadLine());
                        a = Sqrt(4 * S / Sqrt(3.0));
                        R2 = a / Sqrt(3.0);
                        R1 = R2 / 2.0;
                        Console.WriteLine($"{a}\n{R2}\n{R1}\n{S}");
                        break;
                    default:
                        Console.WriteLine("не коректкий ввід");
                        break;
                }
            }
        }
    }
}

using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            FindingSquares();
            Console.WriteLine(new String('.', Console.BufferWidth));
            BankProcent();
            Console.WriteLine(new String('.', Console.BufferWidth));
            NumbersFromAToB();
            Console.WriteLine(new String('.', Console.BufferWidth));
            ReversOfNumber();
            Console.WriteLine(new String('.', Console.BufferWidth));
        }
        static void ReversOfNumber()
        {
            Console.WriteLine("In method ReversOfNumber");
            string GetNumber;
            string EndNumber = "";
            int Length;
            Console.WriteLine("Enter Number more then 0");
            GetNumber = Console.ReadLine();
            Length = GetNumber.Length;
            for (int i = Length - 1; i >= 0; i--)
            {
                EndNumber += GetNumber[i];
            }
            Console.WriteLine(EndNumber);
        }
        static void NumbersFromAToB()
        {
            Console.WriteLine("In method NumbersFromAToB");
            try
            {
                uint A, B;
                Console.Write("Enter A (A>0): ");
                A = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter B (B>A>0): ");
                B = Convert.ToUInt32(Console.ReadLine());
                if (A == 0 || B == 0 || A >= B)
                {
                    throw new Exception();
                }
                for (; A <= B; A++)
                {
                    for (int i = 0; i < A; i++)
                    {
                        Console.Write(A + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BankProcent()
        {
            Console.WriteLine("In method BankProcent");
            try
            {
                double Procent;
                double WishSum = 11000;
                double Sum = 10000;
                int mounth = 0;
                Console.Write("Input procent from 0 to 25: ");
                Procent = Convert.ToDouble(Console.ReadLine());
                if (Procent < 0 || Procent > 25)
                {
                    throw new Exception();
                }
                Procent /= 100;
                while (true)
                {
                    Sum += Sum * Procent;
                    mounth++;
                    if (Math.Round(Sum, 2) > WishSum)
                    {
                        break;
                    }
                }
                Console.WriteLine($"In { mounth} mounths you will have {Math.Round(Sum, 2)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void FindingSquares()
        {
            Console.WriteLine("In method FindingSquares");
            uint A, B, C;
            uint count = 0;
            uint sq = 0;
            try
            {
                Console.Write("Enter A (A>0): ");
                A = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Enter B (B>0): ");
                B = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Enter C (C>0): ");
                C = Convert.ToUInt32(Console.ReadLine());
                if (A == 0 || B == 0 || C == 0)
                {
                    throw new Exception();
                }

                if (A >= C && B >= C)
                {
                    uint hight = A / C;
                    uint wight = B / C;
                    count = wight * hight;
                    sq = A * B - count * C * C;
                }
                Console.WriteLine($"In a rectangle {A}*{B} is {count}" +
                    $" squares and {sq} free square");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

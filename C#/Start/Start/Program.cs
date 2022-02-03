using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main()
        {
            FindingSquares();
            Console.WriteLine(new String('.', Console.BufferWidth));
            BankProcent();
            Console.WriteLine(new String('.', Console.BufferWidth));
            NumbersFromAToB();
            Console.WriteLine(new String('.', Console.BufferWidth));
            ReversOfNumber();
            Console.WriteLine(new String('.', Console.BufferWidth));
            SumSpecialNumbers();
            Console.WriteLine(new String('.', Console.BufferWidth));
            SumSpecialFibonachyNumbers();
            Console.WriteLine(new String('.', Console.BufferWidth));
            FoundMaxSimpelDividerOfNumber();
            Console.WriteLine(new String('.', Console.BufferWidth));
            FoundPalindrom();
            Console.WriteLine(new String('.', Console.BufferWidth));
            FoundNumber();
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
        static void SumSpecialNumbers()
        {
            Console.WriteLine("In method SumSpecialNumbers");
            int MaxNumber = 1000;
            int MinNumber = 0;
            int Divider1 = 3;
            int Divider2 = 5;
            long Sum = 0;

            for (int i = MinNumber; i <= MaxNumber; i++)
            {
                if (i % Divider1 == 0 || i % Divider2 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine($"Sum numbers from {MinNumber} to {MaxNumber}," +
                $" witch are divided into {Divider1} and {Divider2} is {Sum}");
        }
        static void SumSpecialFibonachyNumbers()
        {
            Console.WriteLine("In method SumSpecialFibonachyNumbers");
            int MaxValue = 4000000;
            long Sum = 0;
            for(int i =1; ; i++)
            {
                long GetNumberFib = FibonachyNumber(i);
                if (GetNumberFib > MaxValue)
                {
                    break;
                }
                if (GetNumberFib % 2 == 0)
                {
                    Sum += GetNumberFib;
                }
            }
            Console.WriteLine($"Sum of even Fibonacci numbers less than {MaxValue} is {Sum}");
        }
        static int FibonachyNumber(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else if (i == 2)
            {
                return 2;
            }
            else
            {
                int NumberFib = FibonachyNumber(i - 1) + FibonachyNumber(i - 2);
                return NumberFib;
            }
        }
        static void FoundMaxSimpelDividerOfNumber()
        {
            Console.WriteLine("In method FoundMaxSimpelDividerOfNumber");
            long Number = 600851475143;
            long Divider=1;
            for(long i = 1; i <= Number / 2; i++)
            {
                if (Number % i == 0 && IsSympleNumber(i))
                {
                    Divider = i;
                }
            }
            Console.WriteLine($"Max symple divider of {Number} is {Divider}");
        }
        static bool IsSympleNumber(long number)
        {
            for(long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void FoundPalindrom()
        {
            int Min = 100;
            int Max = 999;
            int result=0;
            for(int i = Min; i <= Max; i++)
            {
                for(int j = Min; j <= Max; j++)
                {
                    if (IsPalindrom(i * j))
                    {
                        result= i * j;
                    }
                }
            }
            Console.WriteLine(result);
        }
        static bool IsPalindrom(int number)
        {
            string StrNumber = number.ToString();
            int Length = StrNumber.Length;
            for(int i=0; i < Length; i++)
            {
                if (StrNumber[i] != StrNumber[Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void FoundNumber()
        {
            long Result = 20;
            while (true)
            {
                if (DividedIntoNumbersFromMintoMax(Result))
                {
                    break;
                }
                Result++;
            }
            Console.WriteLine(Result);
        }
        static bool DividedIntoNumbersFromMintoMax(long number)
        {
            int Min = 1;
            int Max = 20;
            for(int i = Min; i <= Max; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

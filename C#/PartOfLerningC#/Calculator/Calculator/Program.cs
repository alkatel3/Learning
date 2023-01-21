using System;
using static System.Math;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double SecondNumber;
                    double FirstNumber;
                    char Operator;
                    Console.WriteLine("Enter first number (here a):");
                    FirstNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter operator");
                    Console.WriteLine("This calculator does the following:+, -, *, /, ^, %, !");
                    Operator = Convert.ToChar(Console.ReadLine());
                    //if (Operator != '!')
                    //{
                    //    Console.WriteLine("Enter Second Number (here b):");
                    //    SecondNumber = Convert.ToDouble(Console.ReadLine());
                    //}
                    switch (Operator)
                    {
                        case '+':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a+b=" + Sum(FirstNumber, SecondNumber));

                            break;
                        case '-':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a-b=" + Subtraction(FirstNumber, SecondNumber));

                            break;
                        case '*':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a*b=" + Multiplication(FirstNumber, SecondNumber));

                            break;
                        case '/':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a/b=" + Division(FirstNumber, SecondNumber));

                            break;
                        case '^':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a^b=" + Pow(FirstNumber, SecondNumber));

                            break;
                        case '%':
                            Console.WriteLine("Enter Second Number (here b):");
                            SecondNumber = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("a/b=" + RemainderDivision(FirstNumber, SecondNumber));

                            break;
                        case '!':
                            Console.WriteLine("a!" + Factorial(Convert.ToInt32(FirstNumber)));
                            break;
                        default:
                            Console.WriteLine("This operation does not exist");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect enter");                   
                }
                finally
                {
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        //static double CreateSecondNumber()
        //{
        //    Console.WriteLine("Enter Second Number (here b):");
        //    SecondNumber = Convert.ToDouble(Console.ReadLine());
            
        //}
        static double  Sum(double a, double b)
        {
            return a + b;
        }
        static double Subtraction(double a,double b)
        {
            return a-b;
        }
        static double Multiplication(double a, double b)
        {
            return a * b;
        }
        static double Division(double a, double b)
        {
            return a/b;
        }
        static double RemainderDivision(double a,double b)
        {
            return a % b;
        }
        static int Factorial(int a)
        {
            int result=1;
            for(int i = 1; i<= a; i++)
            {
                result *=i;
            }
            return result;
        }
    }
}

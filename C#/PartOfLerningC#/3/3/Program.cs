using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("If you want to leave input 0");
                Console.WriteLine("Input first symbol");

                char symbol1 = Convert.ToChar(Console.ReadLine());
                if (symbol1 == '0')
                    break;
                Console.WriteLine("Input second symbol");
                
                char symbol2 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Input third symbol");
                char symbol3 = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                if (symbol1 == symbol2 && symbol2 == symbol3)
                {
                    Console.WriteLine("All symbol are identical");
                }
                else
                {
                    if (symbol1 == symbol2)
                    {
                        Console.WriteLine("first symbol=second symbol");

                    }
                    else if (symbol2 == symbol3)
                    {
                        Console.WriteLine("second symbol=third symbol");

                    }
                    else if (symbol1 == symbol3)
                    {
                        Console.WriteLine("first symbol=third symbol");

                    }
                    else
                    {
                        Console.WriteLine("All symbol are different");
                    }
                }
                Console.WriteLine();
                
                if (char.IsLetter(symbol1))
                {
                    Console.WriteLine("first symbol is letter");
                }
                if (char.IsLetter(symbol2))
                {
                    Console.WriteLine("second symbol is letter");
                }
                if (char.IsLetter(symbol3))
                {
                    Console.WriteLine("third symbol is letter");
                }
                if (char.IsNumber(symbol1))
                {
                    Console.WriteLine("first symbol is number");
                }
                if (char.IsNumber(symbol2))
                {
                    Console.WriteLine("second symbol is number");
                }
                if (char.IsNumber(symbol3))
                {
                    Console.WriteLine("third symbol is number");
                }
                Console.WriteLine();
                if (char.IsUpper(symbol1))
                {
                    Console.WriteLine( "first symbol is upper");
                }
                if (char.IsUpper(symbol2))
                {
                    Console.WriteLine( "second symbol is upper");
                }
                if (char.IsUpper(symbol3))
                {
                    Console.WriteLine("third symbol is upper");
                }
                Console.WriteLine();
                symbol1 =char.ToUpper(symbol1);
                symbol2=char.ToUpper(symbol2);
                symbol3=char.ToUpper(symbol3);
                Console.WriteLine($"All symbol in upper: '{symbol1}','{symbol2}','{symbol3}'");
                Console.WriteLine();
                
                Console.ReadKey();
                Console.Clear();
                
            }
            for (; ; )
            {
                Console.WriteLine("If you want to leave input '0'");
                Console.WriteLine("Input same first text ");
 
                if (Console.ReadLine() == "0")
                {
                    break;
                }
                string text1 = Console.ReadLine();
                Console.WriteLine("Input same second text ");
                string text2 = Console.ReadLine();
                Console.WriteLine("Input same third text ");
                string text3 = Console.ReadLine();
                if (text1.EndsWith("."))
                {
                    Console.WriteLine("First text have is end '.'");
                }
                if (text2.EndsWith("."))
                {
                    Console.WriteLine("Second text have is end '.'");
                }
                if (text3.EndsWith("."))
                {
                    Console.WriteLine("Third text have is end '.'");
                }
            }
        }
    }
}

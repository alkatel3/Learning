using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
           for(; ; )
            {
                Console.WriteLine("Input first text (more than 4 words)");
                string text1 = Console.ReadLine();
                Console.WriteLine("Input second text (more than 4 words)");
                string text2 = Console.ReadLine();
                string text3 = text1 + " " + text2;
                for (int i = 0; i < text3.Length; i++)
                {
                    if (text3[i] == ' ')
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(text3[i]);
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,] { { 1, -2, 3 }, { -4, 5, -6 }, { 5, -6, 7 } };
            int rang = 0;
            for (int a = 0; a < 3; a++)
            {
                for(int b=0;b<3;b++)
                    if (numbers[a, b] > 0)
                    {
                        rang++;
                    }
                
            }
Console.WriteLine(rang);
        }

    }
}

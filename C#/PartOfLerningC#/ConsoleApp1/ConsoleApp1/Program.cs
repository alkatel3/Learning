using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,] { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 },{ 10, 11, 12 } };
            int rows = numbers.GetUpperBound(0) + 1; // знаходимо кількість рядків
            int columns = numbers.GetUpperBound(1) + 1;// або int columns = mas.Length / rows; знаходими кількість стопців
            for (int i = 0; i < rows; i++)
            {
                for (int g = 0; g < columns; g++)
                {
                    Console.Write($"{numbers[i,g]}\t");
                   
                }
                Console.WriteLine();
            }
           
        }
    }
}

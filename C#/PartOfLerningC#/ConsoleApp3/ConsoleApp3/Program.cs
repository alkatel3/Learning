using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int n = numbers.Length;
            Console.WriteLine(n);
            int k = n / 2;
            int rang;
            for(int i=0;i<k;i++)
            {
                rang = numbers[i];
                numbers[i] = numbers[n - i-1];
                numbers[n - i-1 ] = rang;

            }
            foreach(int a in numbers)
            {
                Console.WriteLine(a);
            }
        }
    }
}

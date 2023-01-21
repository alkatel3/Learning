using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] number = new int[N, N] ;
            
           
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j=0; j < N; j++)
                {
                    Console.WriteLine($"Input number[{i},{j}]:");

                    number[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            //number[1, 0] = 1;
            //number[1, 4] = 2;
            //number[2, 0] = 1;
            //number[2, 1] = 1;
            //number[2, 3] = 2;
            //number[2, 4] = 2;
            //number[3, 0] = 1;
            //number[3, 4] = 2;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < N; j++)
                {
                    Console.Write(number[i, j] + "\t");

                }
            }

        }
    }
}

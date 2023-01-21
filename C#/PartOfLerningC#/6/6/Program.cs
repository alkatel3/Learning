using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; ) {
                Console.WriteLine("Input N");
                var N = Console.ReadLine();
                if (int.TryParse(N, out int n))
                {
                    int result = 0;
                    int i = 0;
                    while (result < n)
                    {

                        i++;
                        result += i;

                    }
                    Console.WriteLine("Max K ={0} (1+2+..+K<N)",--i);
                }
                else
                    Console.WriteLine("N mast to have type int");
                    continue;
            }
        }
    }
}

using System;

namespace ConsoleApp17
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
           int result= faktorial(a);
            Console.WriteLine(result);

        }
      static int faktorial (int n)
        {
            
           if (n == 0)
            {
                return 1;
            }
           return n * faktorial(n - 1);
        }

    }
}

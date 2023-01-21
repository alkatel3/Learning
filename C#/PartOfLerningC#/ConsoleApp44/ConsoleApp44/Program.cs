using System;

namespace ConsoleApp44
{
    
    class Program
    {
 static double sum = 0; 
       static double Operation(double x,double i)
        {
            double F;
            if (i == 1)
            {
                F = x;
                Console.WriteLine(F);
            }
            else
            {
                F = -1 * Operation(x, i - 1) *x* (i-1) / i;
                Console.WriteLine(F);
            }
            sum += F;
            return F;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Operation(0.1, 5);
            Console.WriteLine(sum);
        }
    }
}

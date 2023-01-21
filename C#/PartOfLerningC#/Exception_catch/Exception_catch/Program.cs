using System;

namespace Exception_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = a / 0;
                Console.WriteLine(b);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Exception1 {ex.Message}");
            }
                 int x=1;
                int y=0;

            try
            {
                
               
              int z= x / y;

            }
            catch(DivideByZeroException ) when(x==0&&y==0)

            {
                Console.WriteLine("Exception y=0");
            }
            catch(Exception ex)
            {
                Console.WriteLine( $"Exception2{ex.Message}");
                Console.WriteLine($"Exception2{ex.TargetSite}");
                Console.WriteLine($"Exception2{ex.StackTrace}");
            }
            Console.ReadKey();

        }
    }
}

using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int i = 5; 
             try
             {
                 throw new MyNewException();
                 throw new DivideByZeroException();
             }
             catch(MyNewException ew)
             {
                 Console.WriteLine(ew.Message);
             }
             catch (DivideByZeroException ex) when (i==5)
             {
                 Console.WriteLine("Divide by zero; i=5");
             }
             catch (DivideByZeroException ex)
             {
                 Console.WriteLine("Divide by zero");
             }
             catch (Exception ex)
             {
                 Console.WriteLine("exception");
             }
             finally
             {
                 Console.WriteLine("All Right");
                 Console.ReadLine();
            */
           
            while (true)
               
            {
 var input = Console.ReadLine();
                if (int.TryParse(input,out int result))
                {
                    Console.Clear();
                    Console.WriteLine($"{result} is int");
                    break;
                }
                else
                {
                    Console.WriteLine("input int");
                }
            }
            
        }
    }
}

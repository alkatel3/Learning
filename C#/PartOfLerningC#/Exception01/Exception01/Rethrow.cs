using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception01
{
    class Rethrow
    {
        public static void GetException()
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] num2 = new int[] { 1, 0, 2, 0, 5, 0, 0 };
           
                for (int i = 0; i < num1.Length; i++)
                {
                    try
                    {
                        Console.WriteLine($"{num1[i]}/{num2[i]} = {num1[i] / num2[i]}");
                    }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Divide by zero");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Elemet missing");
                    throw;
                }
                finally
                {
                    Console.WriteLine("finally");
                }
            }
            
        }
    }
}
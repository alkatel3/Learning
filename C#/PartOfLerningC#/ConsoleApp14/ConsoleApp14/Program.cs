using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main (string[] args)
            {
                varg(1, 2, 3, 4, 5);
                int[] vug = new int[] { 1, 2, 3, 4 };
                varg(vug);
                varg();
                Console.ReadLine();
            }
        static void varg (params int[] vag)
        {
            int result = 0;
            for(int i = 0; i < vag.Length; i++)
                {
                result += vag[i];
                
            }
            Console.WriteLine(result);
           
        }

    }
}

using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            math1(1, 2, 3, 4, 5);
            int[] agr = new int[] { 1, 2, 3, 4 };
            math2(agr, 2);
        }
        static void math1(params int[] arg)
        {
            int result = 0;
            for(int i=0; i < arg.Length; i++)
            {
                result += arg[i];
            }
            Console.WriteLine(result);
        }
        static void math2(int[] arg, int k)
        {
            int result = 0;
            for(int i = 0; i < arg.Length; i++)
            {
                result += arg[i] * k;
            }
            Console.WriteLine(result);
        }
    }
}

using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[] { 1, 2, 3, 4, 5, 6 };
           var a= Math0(number);
            Console.WriteLine(a.sum);
            Console.WriteLine(a.sum0);
        }
        static (int sum,int sum0) Math0(int[] a)
        {
            var Operation = (sum: 0, sum0: 0);
            for(int i=0; i<a.Length;i++)
            {
                Operation.sum += a[i];
                Operation.sum0++;
            }
            return Operation;
        }
    }
}

using System;

namespace Adder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            while (true)
            {
                int number=int.Parse(Console.ReadLine());
                if(number<0)
                    break;
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}

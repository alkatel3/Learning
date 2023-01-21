using System;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a / 0;
            Console.WriteLine(b);
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = add(2, 4);
            int y = add(1, 2, 3);
            int z = add(1, 2, 3, 4);
            Console.WriteLine($"{ x}, { y}, { z}");
        }
        static int add(int a, int b,int c=3,int d = 10) //функція з необ'язковими параметрами (c і d)
        {
            return a + b + c * d;
        }
    }
}

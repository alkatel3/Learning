using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           string a = fun1();
Console.WriteLine(a);
            fun0();
 
            int c = fun2();
            Console.WriteLine(c);
        }
        static void fun0()
        {
            Console.WriteLine("buy");
        }
        static string fun1()
        {
            return "hello";
        }
        static int fun2()
        {
            int a = 5;
            int b = 8;

            return a + b;
        }
    }
}

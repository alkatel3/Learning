using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            add(b: 10, a: 15);//виклик метода з іменованими змінними
            add(d: 100, b: 10, a: add(1, 2));
        }
        static int add(int a,int b,int c=10,int d = 11)
        {
            Console.WriteLine(a + b + c + d);
            return a + b + c + d;
        }
    }
}

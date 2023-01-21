using System;

namespace ConsoleApp19
{
    enum Operation 
    {
        a=1,
        b=5,
        c=a+b,
        d=3,
        e=b%d,
        f=e
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operation x;
            x = Operation.a;
            Console.WriteLine((int)x);
            x = Operation.b;
            Console.WriteLine((int)x);
            x = Operation.c;
            Console.WriteLine((int)x);
            x = Operation.d;
            Console.WriteLine((int)x);
            x = Operation.e;
            Console.WriteLine((int)x);
            x = Operation.f;
            Console.WriteLine((int)x);
        }
    }
}

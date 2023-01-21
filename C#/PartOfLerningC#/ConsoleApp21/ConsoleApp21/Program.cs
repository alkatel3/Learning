using System;

namespace ConsoleApp21
{
    class Program
    {
        enum Operation
        {
        a,
        b,
        c,
        d,
        e,
        f
        }
        static void Math0(double x,double y, Operation z)
        {
            double rezult=0.0;
            switch (z)
            {
                case Operation.a:
                    rezult = x + y;
                    break;
                case Operation.b:
                    rezult = x - y;
                    break;
                case Operation.c:
                    rezult = x * y;
                    break;
                case Operation.d:
                    rezult = x / y;
                    break;
                case Operation.e:
                    rezult = x % y;
                    break;
                case Operation.f:
                    rezult = x +2* y;
                    break;
            }
            Console.WriteLine(rezult);
        }
        static void Main(string[] args)
        {
            Math0(5.0, 3.0, Operation.a);
            Math0(5.0, 3.0, Operation.b);
            Math0(5.0, 3.0, Operation.c);
            Math0(5.0, 3.0, Operation.d);
            Math0(5.0, 3.0, Operation.e);
            Math0(5, 3, Operation.f);
        }
    }
}

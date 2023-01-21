using System;

namespace Lesson30
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int i = 30;
                int* address = &i;
                Console.WriteLine(*address);
                Console.WriteLine((long)address );
                int a = 5;
                int b = 7;
                Console.WriteLine("b="+*(&a + 2));
                Calc(a, &b);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Calc(a, ref b);
                Console.WriteLine(a);
                Console.WriteLine(b);
                int* address2 = address + 2;
                *address2 = 777;
                Console.WriteLine((long)address2);
                int** adr = &address;
                Console.WriteLine((long)adr);
                Console.WriteLine((long)*adr);
                Console.WriteLine(**adr);
            }
        }
        static unsafe void Calc(int i,int* j)
        {
            i = 500;
            *j = 700;
        }
        static void Calc(int i,ref int j)
        {
            i = 600;
            j = 800;
        }
    }
}

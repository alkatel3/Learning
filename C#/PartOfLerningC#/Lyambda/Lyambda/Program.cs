using System;

namespace Lyambda
{
    class Program
    {
        delegate bool Param(int x);
        delegate int Operation(int x, int y);
        delegate int Square(int x);
        delegate void Hello();

        static void Main(string[] args)
        {
            Operation operation = ( x, y) => x + y;
            Square square = x => x * x;
            Hello hello = () => Console.WriteLine("Hello");
            hello();
            Console.WriteLine(square(5));

            Console.WriteLine(operation(20, 30));
            Console.WriteLine(operation(40, 30));
            Console.ReadKey();
            int[] param = new int[] { 1, 2, 3, 4, 5, 6, 7 };
           Console.WriteLine( oPeration(param, x => x<5));

            

        }
        static int oPeration(int[] x,Param op)
        {
            int result = 0;
            foreach(int i in x)
            {
                if (op(i))
                    result += i;
               

            }
 return result;
        }
    }
}

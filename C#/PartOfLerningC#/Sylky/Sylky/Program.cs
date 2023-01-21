using System;

namespace Sylky
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            
            ref int XRef = ref x;
            Console.Write($"{x}\t");
            Console.WriteLine(XRef);
            x = 125;
            Console.Write($"{x}\t");
            Console.WriteLine(XRef);
            XRef = 625;
            Console.Write($"{x}\t");
            Console.WriteLine(XRef);
            int x1 = 100;
            XRef = ref x1;
            Console.Write($"{x1}\t");
            Console.WriteLine(XRef);
            
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            ref int NumberRef =ref Number(numbers, 5);
            Console.WriteLine(NumberRef);
            NumberRef = 9;
            Console.WriteLine(numbers[4]);

            int a = 5;
            int b = 6;
            ref int c = ref Max(ref a, ref b);
            Console.WriteLine(c);
            c = 10;
            Console.WriteLine(b);

            Console.ReadKey();
        }
        static ref int Number(int[] numbers, int number)
        {
            for (int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];
                }
                
            }
            throw new Exception("Число не знайдено");
        }
        static ref int Max(ref int a,ref int b)
        {
            if (a > b)
                return ref a;
            else if (a < b)
            {
                return ref b;
            }
            else
                throw new Exception("a=b");

        }
    }
}

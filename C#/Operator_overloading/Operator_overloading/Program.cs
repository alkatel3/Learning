using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var Koef = Koefficients.Parse("123,123");
            Console.WriteLine(Koef);
            Console.WriteLine();

            var z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
            Console.WriteLine();

            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Console.WriteLine(f1);
            Fraction f2 = a * f;
            Console.WriteLine(f2);
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine(f3);
        }
    }
}

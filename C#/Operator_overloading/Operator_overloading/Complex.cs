using System;

/*Реализовать класс для хранения комплексного числа. Выполнить в нем перегрузку всех необходимых 
  операторов для успешной компиляции следующего 
  фрагмента кода:
    //Complex z = new Complex(1,1);
    //Complex z1;
    //z1 = z - (z * z * z - 1) / (3 * z * z);
    //Console.WriteLine("z1 = {0}", z1);
  Краткая справка по комплексным числам 
  (из Википедии):
  • Любое комплексное число может быть представлено 
  как формальная сумма x + iy, где x и y — вещественные 
  числа, i — мнимая единица, то есть число, удовлетворяющее уравнению i2
  = − */

namespace Operator_Overloading
{
    class Complex
    {
        double X, Y;
        
        public Complex(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            double A = c1.X * c2.X - c1.Y * c2.Y;
            double B = c1.X * c2.Y + c1.Y * c1.X;
            return new Complex(A, B);
        }
        public static Complex operator *(Complex c, double number)
        {
            double A = c.X * number;
            double B = c.Y * number;
            return new Complex(A, B);
        }
        public static Complex operator *(double number,Complex c )
        {
            return c * number;
        }
        public static Complex operator -(Complex c, double number)
        {
            return new Complex(c.X - number, c.Y);
        }
        public static Complex operator / (Complex c1, Complex c2)
        {
            double A = (c1.X * c2.X + c1.Y * c2.Y) / (c2.X * c2.X + c2.Y * c2.Y);
            double B = (c1.Y * c2.X - c1.X * c2.Y) / (c2.X * c2.X + c2.Y * c2.Y);
            return new Complex(A, B);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.X - c2.X, c1.Y-c2.Y);
        }
        public override string ToString()
        {
            return $"{X} + {Y} * i";
        }
    }
}

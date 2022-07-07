using System;

/*Разработать класс Fraction, представляющий простую 
  дробь. в классе предусмотреть два поля: числитель
  и знаменатель дроби. Выполнить перегрузку следующих операторов: +,-,*,/,==,!=,<,>, true и false.
  Арифметические действия и сравнение выполняется 
  в соответствии с правилами работы с дробями. Оператор true возвращает true если дробь правильная 
  (числитель меньше знаменателя), оператор false
  возвращает true если дробь неправильная (числитель 
  больше знаменателя).
  Выполнить перегрузку операторов, необходимых для 
  успешной компиляции следующего фрагмента кода:

  //Fraction f = new Fraction(3, 4);
  //int a = 10;
  //Fraction f1 = f * a;
  //Fraction f2 = a * f;
  //double d = 1.5;
  //Fraction f3 = f + d;
*/

namespace Operator_Overloading
{
    class Fraction
    {
        double A;
        double B;

        public Fraction(double a, double b)
        {
            A = a;
            B = b != 0 ? b : 1;
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            double a = f1.A * f2.B + f1.B * f2.A;
            double b = f1.B * f2.B;
            return new Fraction(a, b);
        }
        public static Fraction operator +(Fraction f1, double number)
        {
            double a = f1.A + f1.B * number;
            return new Fraction(a, f1.B);
        }
        public static Fraction operator +( double number,Fraction f1)
        {
            return f1 + number;
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            double a = f1.A * f2.B - f1.B * f2.A;
            double b = f1.B * f2.B;
            return new Fraction(a, b);
        }
        public static Fraction operator -(Fraction f1, double number)
        {
            double a = f1.A - f1.B * number;
            return new Fraction(a, f1.B);
        }
        public static Fraction operator -(double number, Fraction f1)
        {
            return (f1 + number)*(-1);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            double a = f1.A * f2.A;
            double b = f1.B * f2.B;
            return new Fraction(a, b);
        }
        public static Fraction operator *(Fraction f1, double number)
        {
            double a = f1.A * number;
            return new Fraction(a, f1.B);
        }
        public static Fraction operator *(double number, Fraction f1)
        {
            return f1 * number;
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            double a = f1.A * f2.B;
            double b = f1.B * f2.A;
            return new Fraction(a, b);
        }
        public static Fraction operator /(Fraction f1, double number)
        {
            double b = f1.B * number;
            return new Fraction(f1.A, b);
        }
        public static Fraction operator /(double number, Fraction f1)
        {
            double a = number * f1.B;
            return new Fraction(a, f1.A);
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
            bool result = f1.A / f1.B == f2.A / f2.B ? true : false;
            return result;
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            bool result = f1.A / f1.B != f2.A / f2.B ? true : false;
            return result;
        }
        public static bool operator ==(Fraction f1, double number)
        {
            bool result = f1.A / f1.B == number ? true : false;
            return result;
        }
        public static bool operator !=(Fraction f1, double number)
        {
            bool result = f1.A / f1.B != number ? true : false;
            return result;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            bool result = f1.A / f1.B < f2.A / f2.B ? true : false;
            return result;
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            bool result = f1.A / f1.B > f2.A / f2.B ? true : false;
            return result;
        }
        public static bool operator true(Fraction f)
        {
            bool result =f.A<f.B?true:false;
            return result;
        }
        public static bool operator false(Fraction f)
        {
            bool result = f.A > f.B ? true : false;
            return result;
        }

        public override string ToString()
        {
            return $"{A}/{B}";
        }
    }
}

using System;

/*Разработать собственный структурный тип данных 
  для хранения целочисленных коэффициентов A и B 
  линейного уравнения A×X + B×Y = 0. в классе реализовать статический метод Parse(), которые принимает 
  строку со значениями коэффициентов, разделенных 
  запятой или пробелом.
  Разработать метод для решения системы 2 линейных 
  уравнений:
  A1×X + B1×Y = 0
  A2×X + B2×Y = 0
  Метод с помощью выходных параметров должен 
  возвращать найденное решение или ошибку, если 
  решения не существует.*/

namespace Operator_Overloading
{
    struct Koefficients
    {
        int A;
        int B;

        public Koefficients(int a,int b)
        {
            A = a;
            B = b;
        }

        static public Koefficients Parse(string str)
        {
            string[] strs= str.Split(new Char[]{ ' ',','});
            return new Koefficients(Int32.Parse(strs[0]), Int32.Parse(strs[1]));
        }
        public override string ToString()
        {
            return $"{A}*X+{B}*Y=0";
        }
        static public void FigureOutSystem(Koefficients k1, Koefficients k2,out double X,out double Y)
        {
            if (k1.A == k1.B && k2.A == k2.B)
            {
                Console.WriteLine("This system has a lot of solutions");
                X = 0;
                Y = 0;
            }
            else
            {
                X = 0;
                Y = 0;
            }

        }
    }
}

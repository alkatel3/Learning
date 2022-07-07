using System;
using static System.Math;

namespace Task1
{
    class Triangle : Figure
    {
        double Side1;
        double Side2;
        double Side3;
        double Angle;

        public Triangle(double side1, double side2, double angle)
        {
            Side1 = side1;
            Side2 = side2;
            Angle = PI * angle / 180;
            double x1 = Pow(side1, 2);
            double x2 = Pow(side2, 2);
            double x3 = 2 * side1 * side2 * Cos(Angle);
            Side3 = Round(Sqrt(x1 + x2 - x3));
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double Square()
        {
            return Round(Side1 * Side2 * Sin(Angle) / 2,2);
        }
    }
}

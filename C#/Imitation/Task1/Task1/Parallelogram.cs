using System;
using static System.Math;

namespace Task1
{
    class Parallelogram : Figure
    {
        double Side1;
        double Side2;
        double Angle;

        public Parallelogram(double side1, double side2, double angle)
        {
            Side1 = side1 > 0 ? side1 : 1;
            Side2 = side2 > 0 ? side2 : 1;
            Angle = PI * angle / 180;
        }

        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public override double Square()
        {
            return Round(Side1 * Side2 * Sin(Angle),2);
        }
    }
}

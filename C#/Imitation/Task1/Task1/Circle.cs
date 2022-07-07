using System;
using static System.Math;

namespace Task1
{
    class Circle : Figure
    {
        double Radius;
        public Circle(double radius)
        {
            Radius = radius>0?radius:1;
        }
        public override double Perimeter()
        {
            return 2 *Round(PI,2) * Radius;
        }

        public override double Square()
        {
            return Round(PI, 2) * Radius * Radius;
        }
    }
}

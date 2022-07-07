using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;

namespace Task1
{
    class Trapezoidal : Figure
    {
        double SideUp;
        double SideDown;
        double SideLeft;
        double SideRight;
        double H;

        public Trapezoidal(double sideUp, double sideDown, double sideLeft, double sideRight)
        {
            
            SideUp = sideUp>0?sideUp:1;
            SideDown = sideDown>0?sideDown:2;
            SideLeft = sideLeft>0?sideLeft:1;
            SideRight = sideRight > 0 ? sideRight : 1;
            double x0 = SideDown - SideUp;
            
            double x1 = Pow(x0, 2);
            double x2 = Pow(SideLeft, 2);
            double x3 = Pow(SideRight, 2);
            double x4 = x1 + x2 - x3;
            double x5 = x4 / (2 * x0);
            double x6 = Pow(x5, 2);
            double x7= x2-x6;
            double[] x = { x0, x1, x2, x3, x4, x5, x6, x7 };
            H = Sqrt(x7);
        }

        public override double Perimeter()
        {
            return SideLeft + SideRight + SideDown + SideUp;
        }

        public override double Square()
        {
            return (SideUp + SideDown) * H / 2;
        }
    }
}

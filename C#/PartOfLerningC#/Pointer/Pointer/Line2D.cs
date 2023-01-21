using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pointer
{
    class Line2D<T>where T:struct
    {
        Point2D<T> P1;
        Point2D<T> P2;

        public Line2D(Point2D<T> p1, Point2D<T> p2)
        {
            P1 = p1;
            P2 = p2;
        }
        public Line2D(T x1, T y1, T x2, T y2)
        {
            P1 = new(x1, y1);
            P2 = new(x2, y2);
        }
        public override string ToString()
        {
            return $"X1={P1.X}\t" +
                $"Y1={P1.Y}\t" +
                $"X2={P2.X}\t" +
                $"Y2={P2.Y}";
        }
    }
}

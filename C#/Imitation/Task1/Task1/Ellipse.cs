using System;
using static System.Math;

namespace Task1
{
    class Ellipse : Figure
    {
        double SmallRadius;
        double LongRadius;

        public Ellipse(double smallRadius, double longRadius)
        {
            SmallRadius = smallRadius>0?smallRadius:1;
            LongRadius = longRadius>0?longRadius:1;
        }

        public override double Perimeter()
        {
            return (4 * (Round(PI, 2) * SmallRadius * LongRadius + (LongRadius - SmallRadius))) / (SmallRadius + LongRadius);
        }

        public override double Square()
        {
            return Round(PI, 2) * SmallRadius * LongRadius;
        }
    }
}

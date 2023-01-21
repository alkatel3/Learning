using System;

namespace Lesson29
{
    class Point
    {
        public int X { get; set; }
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        public override bool Equals(object obj)
        {
            if (obj is Point point)
            {
                return point.X == X;
            }
            else
            {
                return false;
            }
            
        }
        public override string ToString()
        {
            return X.ToString();
        }
        public Point Clone()
        {
            return MemberwiseClone() as Point;
        }
        public new Type GetType()
        {
            return typeof(UInt16);
        }
    }
}

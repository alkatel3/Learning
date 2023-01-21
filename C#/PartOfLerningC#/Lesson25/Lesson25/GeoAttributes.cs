using System;

namespace Lesson25
{
    class GeoAttribute:Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }
        public GeoAttribute() { }
        public GeoAttribute(int x,int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"[{X};{Y}]";
        }
    }
}

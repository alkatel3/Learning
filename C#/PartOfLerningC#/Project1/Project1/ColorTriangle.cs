using System;

namespace Project1
{
    class ColorTriangle:Triangle
    {
        string Color;
        public ColorTriangle(double Height, double Width, string Style,string Color) : base(Height, Width, Style)
        {
            this.Color = Color;
        }
        public void ShowColor()
        {
            Console.WriteLine($"Color Triangle is {Color}");
        }
    }
}

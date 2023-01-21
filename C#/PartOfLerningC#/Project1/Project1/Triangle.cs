using System;


namespace Project1
{
    class Triangle : TwoDShape
    {
        private string Style;
        public Triangle()
        {
            Style = null;
        }
        public Triangle(double x) : base(x,"трикутник")
        {
            Style = "Рiвнобедерний";
        }
        public Triangle(double Height, double Width, string Style) : 
            base(Height, Width,"трикутник")
        {
            this.Style = Style;
        }
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Трикутник " + Style);
        }
    }
}
using System;

namespace Project1
{
    class Rectangle : TwoDShape 
    {
        public Rectangle(double Height, double Width):
            base(Height, Width, "Прямокутник")
        {

        }
        public Rectangle(double x) :
            base(x, "Прямокутник") 
        {

        }
        public Rectangle(Rectangle ob) : base(ob)
        {

        }
        public bool IsSquare()
        {
            return Width == Height;
        }
        public override double Area()
        {
            return Width*Height;
        }
    }
}

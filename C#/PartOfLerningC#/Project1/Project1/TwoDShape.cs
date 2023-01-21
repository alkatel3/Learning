using System;


namespace Project1
{
    abstract class TwoDShape
    {
        private double pri_Height, pri_Width;
        public TwoDShape()
        {
            Height = Width = 0.0;
            name = "null";
        }
        public TwoDShape(double x,string name)
        {
            Height = Width = x;
            this.name = name;
        }
        public TwoDShape(double Height, double Width, string name)
        {
            this.Height = Height;
            this.Width = Width;
            this.name = name;
        }
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            this.name = ob.name;
        }
        protected double Height
        {
            get
            {
                return pri_Height;
            }
            set
            {
                    pri_Height = value < 0 ? -value : value;
            }
        }
        protected double Width
        {
            get
            {
                return pri_Width;
            }
            set
            {
                 pri_Width = value<0? -value:value;
            }
        }
        public string name { get; set; }
        public void ShowDim()
        {
            Console.WriteLine($"Ширина та висота:\t{Width}\t{Height}");
        }
        public abstract double Area();
    }
}

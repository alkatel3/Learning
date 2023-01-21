using System;

namespace solid_Liskov
{
public class Rectangle
        {
            public virtual int Width { get; set;}
            public virtual int Height { get; set; }

            public Rectangle()
            {
            }

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public int Area => Width * Height;
            public override string ToString()
            {
                return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
            }
        }
    public class Square: Rectangle
    {
        public Square(int side)
        {
            Width = Height = side;
        }
        public override int Height { 
            set
            {
                base.Width = base.Height = value;
            }
        }
        public override int Width  
        {
            set
            {
               base.Height = base.Width =  value;
            }
        }
    }
    class Program
    {
        public static void UseIt(Rectangle r)
        {
            int width = r.Width;
            r.Height = 10;
            Console.WriteLine($"({10*width})=={r.Area}");
        }
        static void Main(string[] args)
        {
            var rc = new Rectangle(3, 2);
            UseIt(rc);
            var sq = new Square(5);
            UseIt(sq);
        }
    }
}

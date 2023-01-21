using System;

namespace GameSnake
{
    struct Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public char ch { get; set; }
        public static implicit operator Point((int, int, char) Value) =>
           new Point() { x = Value.Item1, y = Value.Item2, ch = Value.Item3 };
        //public Point(int x, int y, char ch)
        //{
        //    this.x = x;
        //    this.y = y;
        //    this.ch = ch;
        //}
        public static bool operator ==(Point a, Point b) =>
                  (a.x == b.x && a.y == b.y);

        public static bool operator !=(Point a, Point b) =>
                  (a.x != b.x && a.y != b.y);

        private void DrawPoint(char _ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_ch);
        }

        public void Draw()
        {
            DrawPoint(ch);
        }
        public void Clear()
        {
            DrawPoint(' ');
        }
    }
}

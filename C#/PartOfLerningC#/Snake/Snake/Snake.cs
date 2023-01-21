using System;
using System.Collections.Generic;
using System.Linq;


namespace GameSnake
{
    class Snake
    {
        private List<Point> snake;
        private Direction direction;
        private int step = 1;
        private Point tail;
        private Point head;
        bool rotate = true;
        public Snake(int x,int y,int length)
        {
            direction = Direction.RIGHT;
            snake = new List<Point>();
            for(int i = x - length; i < x; i++)
            {
                Point point = (i, y, (char)('H'^88));
                snake.Add(point);
                point.Draw();
            }
            
        }
        public Point GetHead() => snake.Last();
        public void Move()
        {
            head = GetNextPoint();
            snake.Add(head);
            tail = snake.First();
            snake.Remove(tail);
            tail.Clear();
            head.Draw();
            rotate = true;
        }
        public Point GetNextPoint()
        {
            Point point = GetHead();
            switch (direction)
            {
                case Direction.RIGHT:
                    point.x += step;
                    break;
                case Direction.LEFT:
                    point.x -= step;
                    break;
                case Direction.UP:
                    point.y -= step;
                    break;
                case Direction.DOWN:
                    point.y += step;
                    break;
            }
            return point;
        }
        public void Rotation(ConsoleKey key)
        {
            if (rotate)
            {
                switch (direction) 
                {
                    case Direction.LEFT:
                    case Direction.RIGHT:
                        if (key == ConsoleKey.DownArrow)
                            direction = Direction.DOWN;
                        else if (key == ConsoleKey.UpArrow)
                            direction = Direction.UP;
                        break;
                    case Direction.UP:
                    case Direction.DOWN:
                        if (key == ConsoleKey.LeftArrow)
                            direction = Direction.LEFT;
                        else if (key == ConsoleKey.RightArrow)
                            direction = Direction.RIGHT;
                        break;
                }
                rotate = false;
            }
        }
        //public void Rotation(ConsoleKey key)
        //{
        //    if (rotate)
        //    {
        //        switch (key)
        //        {
        //            case ConsoleKey.DownArrow:
        //                direction = Direction.DOWN;
        //                break;
        //            case ConsoleKey.UpArrow:
        //                direction = Direction.UP;
        //                break;
        //           case ConsoleKey.RightArrow:
        //                direction = Direction.Rigt;
        //                break;
        //            case ConsoleKey.LeftArrow:
        //                direction = Direction.LEFT;
        //                break;
        //        }
        //        rotate = false;
        //    }
        //}
        public bool IsHit(Point point)
        {
            for(int i =snake.Count-2;i>0;i--)
            {
                if ( snake[i]==point )
                    return true;
            }
            return false;
        }
        public bool Eat(Point point)
        {
            head = GetNextPoint();
            if (head == point)
            {
                snake.Add(head);
                head.Draw();
                return true;
            }
            return false;
        }
    }
}
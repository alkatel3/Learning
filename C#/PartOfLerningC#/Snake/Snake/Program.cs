using System;
using System.Threading;

namespace GameSnake
{
    class Game
    {
        static readonly int x = 80;
        static readonly int y = 26;
        static Walls walls;
        static Snake snake;
        static FoodFactory foodFactory;
        static bool information = true;
        static Timer time;
        static void Main()
        {
                Console.SetWindowSize(x + 1, y + 1);
                Console.SetBufferSize(x + 1, y + 1);
                Console.CursorVisible = false;
                walls = new Walls(x, y, '#');
                snake = new Snake(x / 2, y / 2, 3);
                foodFactory = new FoodFactory(x, y, '@');
                foodFactory.CreateFood();
                //var timerCallBack = new TimerCallback(Loop);
                time = new Timer(Loop, null, 0, 100);
                while (information)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.Rotation(key.Key);
                    }
                }
            information = true;
            Console.Clear();
            //Console.ReadKey();
        }//Main
        static void Loop(object obj)
        {
            if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Change(0, Timeout.Infinite);
                information = false;
                //return information;

            }
            else if (snake.Eat(foodFactory.food))
            {
                foodFactory.CreateFood();
            }
            else
            {
                snake.Move();
            }
            //return information;
        }
    }
}

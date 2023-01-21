using System;

namespace GameSnake
{
    class FoodFactory
    {
        private  int x;
        private int y;
        private char ch;
        public Point food { get; private set; }
        private  Random random = new Random();
        
        public FoodFactory(int x,int y,char ch)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
            
        }
        public void CreateFood()
        {
            food = (random.Next(1, x - 2), random.Next(2, y - 2), ch);
            food.Draw();
        }
    }
}

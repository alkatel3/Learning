using System;
using System.Collections.Generic;

namespace GameSnake
{
    class Walls
    {
        private char ElementWalls { get; set; }
        private List<Point> PointsWalls = new List<Point>();

        public Walls(int x,int y,char ElementWalls) 
        {
            this.ElementWalls = ElementWalls;
            DrawHorizontal(x, 0);
            DrawVertical(x, y);
            DrawVertical(0, y);
            DrawHorizontal(x, y);

        }
        private void DrawHorizontal(int x,int y)
        {
            for(int i = 0; i < x; i++)
            {
                Point point = (i, y, ElementWalls);
                point.Draw();
                PointsWalls.Add(point);
            }
        }
        private void DrawVertical(int x, int y)
        {
            for (int i =0; i < y; i++)
            {
                Point point = (x, i, ElementWalls);
                point.Draw();
                PointsWalls.Add(point);
            }
        }
        public bool IsHit(Point point)
        {
            foreach(var pointWalls in PointsWalls)
            {
                if (point == pointWalls)
                    return true;
            }
            return false;
        }
    }
}

﻿
namespace Graph
{
    public class Vertex
    {
        public int Number { get; set; }

        public Vertex(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
        public override bool Equals(object? obj)
        {
            if(obj is Vertex v)
            {
                return v.Number.Equals(Number);
            }
            return false;
        }
    }
}

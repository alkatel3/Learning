using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Car
    {
        public void Move(SquareGraph graph, Vertex start, Vertex finish)
        {
            var current = start;
            current.IsCat = true;

            graph.ShowInGraphConsole();
            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine();
            while (!current.Equals(finish))
            {
                current.IsCat = false;
                var list = graph.GetEdgeLists(current);
                for (int i = 0; ; i++)
                {
                    if (list.FindAll(e => e.visited == i).Count != 0)
                    {
                        list = list.FindAll(e => e.visited == i);
                        break;
                    }

                }
                var currentEdge = list[0];
                foreach(var item in list)
                {
                    if (item.Weight < currentEdge.Weight)
                    {
                        currentEdge = item;
                    }
                }
                currentEdge.visited++;
                graph.GetEdgeLists(currentEdge.Vertex2).Find(e => e.Vertex2 == current).visited++;
                current = currentEdge.Vertex2;
                current.IsCat = true;
                graph.ShowInGraphConsole();
                Console.WriteLine();
                Console.WriteLine("*****************");
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class SquareGraph:Graph
    {
        private Vertex[,] vertexes;
        private int Size;

        public SquareGraph (int size = 5)
        {
            Size = size;
            vertexes = new Vertex[size, size];
            CreatSquareGraph(size);
        }

        private void CreatSquareGraph(int size = 5)
        {
            var rnd = new Random();
            if (size < 2)
            {
                Console.WriteLine("Side must be not less then 2");
                size = 2;
            }

            for(int i=0; i< size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var vertex = new Vertex(i* size + j);
                    AddVertex(vertex);
                    vertexes[i,j] = vertex;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i== size - 1 && j == size - 1)
                    {
                        continue;
                    }
                    else if(j== size - 1 && i < size - 1)
                    {
                        AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                    else if(i== size - 1 && j < size - 1)
                    {
                        AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                    }
                    else
                    {
                        AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                        AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                }
            }
        }
        public void RemoveEdges(int Count)
        {
            if (Count > EdgeCount - VertexCount + 1)
            {
                throw new ArgumentException("The graph must be connected", nameof(Count));
            }
            var rnd = new Random();
            var removed = false;
            while(Count!=0)
            foreach(var vertex in vertexes)
            {
                
                var list = GetVertexLists(vertex);
                
                var vertex2 = list[rnd.Next(list.Count)];
                RemoveEdge(vertex, vertex2);
                removed = true;

                foreach(var ver in vertexes)
                {
                    if (Wave(vertex, ver))
                    {
                        continue;
                    }
                    else
                    {
                        AddEdge(vertex, vertex2);
                        removed = false;
                        break;

                    }
                }
                if (removed)
                {
                    Count--;
                    removed = false;
                }
                if(Count == 0)
                {
                    break;
                }
            }
        }

        public void ShowInGraphConsole()
        {
            for(int i =0; i< Size; i++)
            {
                for(int j=0; j < Size; j++)
                {
                    if (vertexes[i, j].IsCat)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("o");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.Write("o");
                    }
                    if (j == Size - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if(IsWay(vertexes[i,j], vertexes[i, j + 1]))
                        {
                            Console.Write(" - ");
                        }
                        else
                        {
                            Console.Write("   ");
                        }
                    }
                }
                Console.WriteLine();
                if(i==Size - 1)
                {
                    continue;
                }

                else
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (IsWay(vertexes[i, j], vertexes[i+1, j]))
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

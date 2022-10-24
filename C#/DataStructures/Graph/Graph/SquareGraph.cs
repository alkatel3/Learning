using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class SquareGraph
    {
        public Graph Graph{get;set;}
        private Vertex[,] vertexes;
        public SquareGraph (int side = 5)
        {
            Graph=GetSquareGraph(side);
        }

        private Graph GetSquareGraph(int side = 5)
        {
            var rnd = new Random();
            vertexes =new Vertex[side,side];
            if (side < 2)
            {
                Console.WriteLine("Side must be not less then 2");
                side = 2;
            }
            var Graph=new Graph();

            for(int i=0; i<side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    var vertex = new Vertex(i*side+j);
                    Graph.AddVertex(vertex);
                    vertexes[i,j] = vertex;
                }
            }

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Graph.AddEdge(vertexes[i,j], vertexes[i,j+1],rnd.Next(1,9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i+1, j], rnd.Next(1, 9));
                    }
                    else if (i == 0 && j>0 && j < side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i+1, j], rnd.Next(1, 9));
                    }
                    else if(i==0 && j == side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                    else if (j == 0 && i>0 && i< side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i-1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i+1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j+1], rnd.Next(1, 9));
                    }
                    else if (j == 0 && i == side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i-1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j+1], rnd.Next(1, 9));
                    }
                    else if (i == side-1 && j > 0 && j < side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i - 1, j], rnd.Next(1, 9));
                    }
                    else if (i == side-1 && j == side-1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i - 1, j], rnd.Next(1, 9));
                    }
                    else if (j==side-1 && i > 0 && i < side - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i - 1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                    }
                    else
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j - 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i - 1, j], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                }
            }
                    return Graph;
        }
        public void RemoveEdges(int Count)
        {
            var list=Graph.GetVertexLists(vertexes[0, 0]);
            Graph.RemoveEdge(vertexes[0, 0], list[0]);
            Graph.RemoveEdge(list[0], vertexes[0,0]);
            var vertex = list[1];
            list = Graph.GetVertexLists(vertex);
            if (list.Count > 2)
            {
                Graph.RemoveEdge(vertexes[0, 0], list[0]);
                Graph.RemoveEdge(list[0], vertexes[0, 0]);
            }


            //if (Count > Graph.EdgeCount-Graph.VertexCount-1)
            //{
            //    throw new ArgumentException();
            //}
            //while (Count > 0)
            //{
            //    foreach (var vertex in vertexes)
            //    {
            //        if (Count == 0)
            //        {
            //            break;
            //        }
            //        var list = Graph.GetVertexLists(vertex);
            //        Vertex vertex1 = null;
            //        if (list.Count == 1)
            //        {
            //            continue;
            //        }
            //        foreach (var item in list)
            //        {
            //            if (Graph.GetVertexLists(item).Count > 1)
            //            {
            //                vertex1 = item;
            //                break;
            //            }
            //        }
            //        if (vertex1 != null)
            //        {
            //            Console.WriteLine(Graph.RemoveEdge(vertex, vertex1));
            //            Graph.RemoveEdge(vertex1, vertex);
            //            Count--;
            //        }
            //    }
            //}
        }

    }
}

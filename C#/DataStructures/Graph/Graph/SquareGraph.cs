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
        private int Size;
        public SquareGraph (int size = 5)
        {
            Size = size;
            Graph=GetSquareGraph(size);
        }

        private Graph GetSquareGraph(int size = 5)
        {
            var rnd = new Random();
            vertexes =new Vertex[size, size];
            if (size < 2)
            {
                Console.WriteLine("Side must be not less then 2");
                size = 2;
            }
            var Graph=new Graph();

            for(int i=0; i< size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var vertex = new Vertex(i* size + j);
                    Graph.AddVertex(vertex);
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
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                    else if(i== size - 1 && j < size - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                    }
                    else
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                }
            }
                    return Graph;
        }
        public void RemoveEdges(int Count)
        {
            var maxCount = this.Graph.EdgeCount - (this.Graph.VertexCount - 1);
            if (Count > maxCount)
            {
                throw new ArgumentException();
            }
            var rnd = new Random();
            vertexes = new Vertex[Size, Size];
            var Graph = new Graph();

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var vertex = new Vertex(i * Size + j);
                    Graph.AddVertex(vertex);
                    vertexes[i, j] = vertex;
                }
            }





            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == Size - 1 && j == Size - 1)
                    {
                        continue;
                    }
                    else if (j == Size - 1 && i < Size - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                    }
                    else if (i == Size - 1 && j < Size - 1)
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                    }
                    else
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i, j + 1], rnd.Next(1, 9));
                    }
                }
            }
            for (int i = 0; i < Size && maxCount-Count > 0; i++)
            {
                for (int j = 0; j < Size && maxCount-Count>0; j++)
                {
                    if (i == Size - 1 && j == Size - 1)
                    {
                        continue;
                    }
                    else if (j == Size - 1 && i < Size - 1)
                    {
                        continue;
                    }
                    else if (i == Size - 1 && j < Size - 1)
                    {
                        continue;
                    }
                    else
                    {
                        Graph.AddEdge(vertexes[i, j], vertexes[i + 1, j], rnd.Next(1, 9));
                        Count++;
                    }
                }
            }

            this.Graph = Graph;




            //var rnd = new Random();

            //while(Count >0)
            //{
            //    var v1 = new Vertex(rnd.Next(0, Size * Size - 1));
            //    var v2 = new Vertex(rnd.Next(0, Size * Size - 1));
            //    if (Graph.GetVertexLists(v1).Count > 2 & Graph.GetVertexLists(v2).Count > 2)
            //    {
            //        Console.WriteLine(Graph.GetVertexLists(v1).Count);
            //        Console.WriteLine(Graph.GetVertexLists(v2).Count);
            //        if (Graph.RemoveEdge(v1, v2))
            //        {
            //            Count--;
            //        }
            //    }
            //}










            //for(int i=0; i<Size; i++)
            //{
            //    for(int j =0; j < Size-1; j++)
            //    {   if (j % 2 == 0 && i < Size - 1)
            //        {
            //            Graph.RemoveEdge(vertexes[i, j], vertexes[i, j + 1]);
            //        }
            //        else
            //        {

            //        }

            //    }
            //}





            //if (Count > Graph.EdgeCount - (Graph.VertexCount - 1))
            //{
            //    throw new ArgumentException();
            //}


            //var current = vertexes[0, 0];
            //var CountOne = 2;
            //var result = false;
            //while (Count > 0)
            //{
            //    var list = Graph.GetVertexLists(current);
            //    if (list.Count <= 2)
            //    {
            //        current = list[0];
            //        continue;
            //    }
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        var v = list[i];
            //        if (Graph.GetVertexLists(v).Count >= 2 && CountOne!=0)
            //        {
            //            if (Graph.RemoveEdge(current, v))
            //            {
            //                list = Graph.GetVertexLists(current);
            //                if (/*list.Count < 2 || */Graph.GetVertexLists(v).Count<2)
            //                {
            //                    current = list[0];
            //                    CountOne--;
            //                }
            //                else
            //                {
            //                    current = list[1];
            //                }
            //                result = true;
            //                break;
            //            }
            //            else continue;
            //        }
            //        else if(Graph.GetVertexLists(v).Count > 2)
            //        {
            //            if (Graph.RemoveEdge(current, v))
            //            {
            //                list = Graph.GetVertexLists(current);
            //                if (/*list.Count < 2 || */Graph.GetVertexLists(v).Count < 2)
            //                {
            //                    current = list[0];
            //                    CountOne--;
            //                }
            //                else
            //                {
            //                    current = list[1];
            //                }
            //                result = true;
            //                break;
            //            }
            //            else continue;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }

            //    if (result)
            //    {
            //        Count--;
            //        result = false;
            //    }
            //    else
            //    {
            //        current = list[0];
            //    }
            //}



            //var list=Graph.GetVertexLists(vertexes[0, 0]);
            //Graph.RemoveEdge(vertexes[0, 0], list[0]);
            //Graph.RemoveEdge(list[0], vertexes[0,0]);
            //var vertex = list[1];
            //list = Graph.GetVertexLists(vertex);
            //if (list.Count > 2)
            //{
            //    Graph.RemoveEdge(vertexes[0, 0], list[0]);
            //    Graph.RemoveEdge(list[0], vertexes[0, 0]);
            //}


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

        public void ShowInGraphConsole()
        {
            for(int i =0; i< Size; i++)
            {
                for(int j=0; j < Size; j++)
                {
                    Console.Write("o");
                    if (j == Size - 1)
                    {
                        continue;
                    }
                    else
                    {
                        if(Graph.IsWay(vertexes[i,j], vertexes[i, j + 1]))
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
                        if (Graph.IsWay(vertexes[i, j], vertexes[i+1, j]))
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

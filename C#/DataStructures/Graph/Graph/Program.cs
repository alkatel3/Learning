using MNIST.IO;

namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test graph
            //var graph = new Graph();

            //var v1 = new Vertex(1);
            //var v2 = new Vertex(2);
            //var v3 = new Vertex(3);
            //var v4 = new Vertex(4);
            //var v5 = new Vertex(5);
            //var v6 = new Vertex(6);
            //var v7 = new Vertex(7);

            //graph.AddVertex(v1);
            //graph.AddVertex(v2);
            //graph.AddVertex(v3);
            //graph.AddVertex(v4);
            //graph.AddVertex(v5);
            //graph.AddVertex(v6);
            //graph.AddVertex(v7);

            //graph.AddEdge(v1, v2, 8);
            //graph.AddEdge(v1, v3, 9);
            //graph.AddEdge(v3, v4, 3);
            //graph.AddEdge(v2, v5, 1);
            //graph.AddEdge(v2, v6, 5);
            //graph.AddEdge(v6, v5);
            //graph.AddEdge(v5, v6, 2);

            //GetMatrix(graph);
            //Console.WriteLine();
            //Console.WriteLine();
            //GetVertex(graph, v1);
            //GetVertex(graph, v2);
            //GetVertex(graph, v3);
            //GetVertex(graph, v4);
            //GetVertex(graph, v5);
            //GetVertex(graph, v6);
            //GetVertex(graph, v7);

            //Console.WriteLine(graph.Wave(v1, v5));
            //Console.WriteLine(graph.Wave(v2, v4));
            //Console.WriteLine(graph.RemoveEdge(new Vertex(1), new Vertex(2)));
            //Console.WriteLine(graph.RemoveEdge(new Vertex(2), new Vertex(5)));
            //Console.WriteLine(graph.RemoveEdge(new Vertex(1), new Vertex(6)));
            //Console.WriteLine(graph.RemoveEdge(new Vertex(26), new Vertex(25)));

            //GetVertex(graph, v1);
            //GetMatrix(graph);
            //Console.WriteLine();
            //Console.WriteLine();
            #endregion

            var graph = new SquareGraph(5);
            graph.RemoveEdges(16);

            var Car1 = new Car();

            var Egdes = graph.GetEdgeLists(new Vertex(10));
            var Start = Egdes[0].Vertex1;

            Egdes = graph.GetEdgeLists(new Vertex(24));
            var Finish = Egdes[0].Vertex1;

            Car1.Move(graph, Start, Finish, true);


            var map1 = Car1.ShortWay;
            var way1 = Car1.FullWay;

            foreach (var item in way1)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();

            foreach (var item in map1)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
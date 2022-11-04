
namespace Graph
{
    public class Graph
    {
        List<Vertex> Vertices = new List<Vertex>();
        List<Edge> Edges = new List<Edge>();

        public int VertexCount  => Vertices.Count;
        public int EdgeCount =0;

        public void AddVertex(Vertex vertex)
        {
            if (Vertices.Contains(vertex))
            {
                return;
            }
            Vertices.Add(vertex);
        }

        public void AddEdge(Vertex Vertex1, Vertex Vertex2, int weight=1)
        {
            if (Vertex1.Equals(Vertex2))
            {
                return;
            }
            var edge = new Edge(Vertex1, Vertex2, weight);
            var edge2 = new Edge(Vertex2, Vertex1, weight);
            if (Edges.Contains(edge))
            {
                Console.WriteLine($"Way ({Vertex1}:{Vertex2}) already exists");
                return;
            }
            Edges.Add(edge);
            Edges.Add(edge2);
            EdgeCount++;
        }

        public bool IsWay(Vertex vertex1, Vertex vertex2)
        {
            var list = GetVertexLists(vertex1);
            return list.Contains(vertex2);
        }

        //public int[,] GetMatrix()
        //{
        //    var matrix = new int[Vertices.Count, Vertices.Count];

        //    foreach(var edge in Edges)
        //    {
        //        var row = edge.Vertex1.Number-1;
        //        var column = edge.Vertex2.Number-1;

        //        matrix[row, column] = edge.Weight;
        //    }
        //    return matrix;
        //}

        public List<Vertex> GetVertexLists(Vertex vertex)
        {
            var result=new List<Vertex>();
            foreach(var edge in Edges)
            {
                if (edge.Vertex1.Equals(vertex))
                {
                    result.Add(edge.Vertex2);
                }
            }

            return result;
        }


        public bool Wave(Vertex start, Vertex finish)
        {

            var list = new List<Vertex>();

            list.Add(start);


            for (int i = 0; i < list.Count; i++)
            {
                var vertex = list[i];

                foreach (var v in GetVertexLists(vertex))
                {
                    if (!list.Contains(v))
                    {
                        list.Add(v);
                    }
                }
            }

            return list.Contains(finish);
        }

        public bool RemoveEdge(Vertex Vertex1, Vertex Vertex2)
        {
            var edge = new Edge(Vertex1, Vertex2);
            var edge2 = new Edge(Vertex2, Vertex1);
            bool result = Edges.Remove(edge) && Edges.Remove(edge2);
            if (result)
            {
                EdgeCount--;
            }
            return result;
        }
    }
}

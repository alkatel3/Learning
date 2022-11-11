
namespace Graph
{
    public class Edge
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public int visited { get; set; }
        public int Weight { get; set; }

        public Edge(Vertex vertex1 , Vertex vertex2, int weight=1)
        {
            Vertex1 = vertex1;
            Vertex2 = vertex2;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"({Vertex1};  {Vertex2})";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Edge edge)
            {
                return edge.Vertex1.Equals(Vertex1) &&edge.Vertex2.Equals(Vertex2);
            }
            return false;
        }
    }
}

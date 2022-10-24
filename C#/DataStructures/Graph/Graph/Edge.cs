
namespace Graph
{
    public class Edge
    {
        public Vertex From { get; set; }
        public Vertex To { get; set; }

        public int Weight { get; set; }

        public Edge(Vertex from , Vertex to, int weight=1)
        {
            From = from;
            To = to;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"({From};  {To})";
        }
        public override bool Equals(object? obj)
        {
            if(obj is Edge edge)
            {
                return edge.From.Equals(From)&&edge.To.Equals(To);
            }
            return false;
        }
    }
}

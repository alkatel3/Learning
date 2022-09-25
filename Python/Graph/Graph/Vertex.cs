
namespace Graph
{
    public class Vertex//<T>
    {
        public int Number { get; set; }

        //T Data;

        public Vertex(int number)
        {
            Number = number;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}

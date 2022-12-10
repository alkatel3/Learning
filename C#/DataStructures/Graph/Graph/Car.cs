namespace Graph
{
    public class Car
    {
        public List<Vertex> ShortWay = new List<Vertex>();
        public List<Vertex> FullWay = new List<Vertex>();
        public void Move(SquareGraph graph, Vertex start, Vertex finish, bool WithSigns)
        {
            var current = start;
            current.IsCat = true;

            ShowState(graph);
            CreatWay(current);

            while (!current.Equals(finish))
            {
                current.IsCat = false;
                var currentEdge = ChooseEdge(current,finish, graph, WithSigns);

                currentEdge.Visited++;
                graph.GetEdgeLists(currentEdge.Vertex2).Find(e => e.Vertex2 == current).Visited++;

                current = currentEdge.Vertex2;
                current.IsCat = true;

                ShowZnak(currentEdge);
                int speed = GetSpeed(currentEdge);
                ShowCurrentSpeed(speed);
                ShowState(graph);
                CreatWay(current);
            }
            current.IsCat = false;
            graph.ClearKnowledgeBase();
        }

        private void ShowCurrentSpeed(int speed)
        {
            Console.WriteLine($"Current speed: {speed} km/h");
        }

        private void ShowZnak(Edge edge)
        {
            Console.WriteLine(MnistData.ToStringImage(edge.Speed));
        }
        private void CreatWay(Vertex current)
        {
            ShortWay.Add(current);
            FullWay.Add(current);
            if (ShortWay.FindAll(v => v == current).Count > 1)
            {
                var index1 = ShortWay.IndexOf(current);
                var index = ShortWay.LastIndexOf(current);
                for (int i = index1; i < index; i++)
                    ShortWay.RemoveAt(index1);
            }
        }

        private void ShowState(SquareGraph graph)
        {
                graph.ShowInGraphConsole();
                Console.WriteLine();
                Console.WriteLine("*****************");
                Console.WriteLine();
        }

        private Edge ChooseEdge(Vertex current, Vertex finish, SquareGraph graph, bool WithSigns)
        {
            if (WithSigns)
            {
                if (graph.GetVertexLists(current).Contains(finish))
                {
                    return graph.GetEdgeLists(current).Find(e => e.Vertex2 == finish);
                }
                foreach (var v in graph.GetVertexLists(current))
                {
                    if (graph.GetVertexLists(v).Contains(finish))
                    {
                        return graph.GetEdgeLists(current).Find(e => e.Vertex2 == v);
                    }
                    if (graph.GetVertexLists(v).Count == 0)
                    {
                        graph.GetEdgeLists(current).Find(e => e.Vertex2 == v).Visited += 2;
                    }
                }
            }
            var list = graph.GetEdgeLists(current);
            for (int i = 0; ; i++)
            {
                if (list.FindAll(e => e.Visited == i).Count != 0)
                {
                    list = list.FindAll(e => e.Visited == i);
                    break;
                }

            }
            var currentEdge = list[0];
            foreach (var item in list)
            {
                if (item.Weight < currentEdge.Weight)
                {
                    currentEdge = item;
                }
            }
            return currentEdge;
        }

        private int GetSpeed(Edge edge)
        {
            var image = edge.Speed;
            var DataSet = MnistData.Data.FirstOrDefault(d => d.Image == image);
            var speed = DataSet.Label;
            speed *= 10;
            return speed;
        }
    }
}

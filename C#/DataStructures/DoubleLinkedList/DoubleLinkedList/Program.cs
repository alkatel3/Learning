namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new DoubleLinkedList<int>();
            for(int i = 0; i < 10; i++)
            {
                List.Add(i);
            }

            foreach(var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i+=2)
            {
                List.Delete(i);
            }

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                List.Add(i);
            }

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var List2 = List.Reverse();

            foreach (var item in List2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
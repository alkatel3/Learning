
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new Model.LinkedList<int>();
            for(int i=1;i<5; i++)
            {
                List.Add(i);
            }

            foreach(var item in List)
            {
                Console.WriteLine(item);
            }
            List.Add(3);
            List.Remove(3);
            List.Remove(1);
            List.Remove(7);
            List.Add(2);
            List.Add(9);
            List.Add(7);
            Console.ReadLine();
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(List.Count);
            List.InsertAt(10, 0);
            Console.WriteLine();
            Console.WriteLine(List.Count);
            List.InsertAt(10, 3);
            Console.WriteLine();
            Console.WriteLine(List.Count);
            List.InsertAt(10, List.Count);
            Console.WriteLine();
            Console.WriteLine(List.Count);
            List.InsertAt(10, List.Count - 2);
            Console.WriteLine();
            Console.WriteLine(List.Count);
            List.InsertAt(10, List.Count-1);
            Console.WriteLine();
            Console.WriteLine(List.Count);
            Console.ReadLine();



            foreach (var item in List)
            {
                Console.WriteLine(item);
            }

            List.RemoveAt(List.Count - 2);
            List.RemoveAt(List.Count - 3);
            List.RemoveAt(List.Count-1);
            List.RemoveAt(3);
            List.RemoveAt(0);
            Console.WriteLine();
            Console.WriteLine(List.Count);

            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
namespace CircularList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var List = new CircularList<int>();

            for(int i = 0; i < 10; i++)
            {
                List.Add(i);
            }
            foreach(var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            for (int i = 0; i < 10; i++)
            {
                List.Add(i);
            }
            for (int i = 9; i >= 0; i--)
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
            for (int i = 0; i < 10; i += 2)
            {
                List.Delete(i);
            }
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //for (int i = 0; i < 10; i++)
            //{
            //    List.Add(i);
            //}
            for (int i = 0; i < 10; i++)
            {
                List.Delete(i);
            }
            foreach (var item in List)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
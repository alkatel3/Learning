namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dict<int, string>();

            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(1, "One"));
            dict.Add(new Item<int, string>(2, "Two"));
            dict.Add(new Item<int, string>(3, "Three"));
            dict.Add(new Item<int, string>(4, "Four"));
            dict.Add(new Item<int, string>(5, "five"));
            dict.Add(new Item<int, string>(101, "a hundred and one"));

            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(dict.Search(7) ?? "Not");
            Console.WriteLine(dict.Search(3) ?? "Not");
            Console.WriteLine(dict.Search(101) ?? "Not");
            Console.WriteLine();
            dict.Remove(7);
            dict.Remove(3);
            dict.Remove(1);
            dict.Remove(101);


            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            var dict2 = new Dict<int, string>();
            for (int i = 0; i < 100; i++)
            {
                dict2.Add(new Item<int, string>(i, Convert.ToString(i)));
            }
            dict2.Add(new Item<int, string>(100, "hello"));
            foreach(var item in dict2)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();




            var easyMap = new EasyMap<int, string>();

            easyMap.Add(new Item<int, string>(1, "One"));
            easyMap.Add(new Item<int, string>(2, "Two"));
            easyMap.Add(new Item<int, string>(3, "Three"));
            easyMap.Add(new Item<int, string>(4, "Four"));
            easyMap.Add(new Item<int, string>(5, "five"));

            foreach(var item in easyMap)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(easyMap.Search(7) ?? "Not");
            Console.WriteLine(easyMap.Search(3) ?? "Not");
            Console.WriteLine();
            easyMap.Remove(3);
            easyMap.Remove(1);


            foreach (var item in easyMap)
            {
                Console.WriteLine(item);
            }

        }
    }
}
namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            var easySet1 = new EasySet<int>(new int[] { 1, 2, 3, 4, 5 });
            var easySet2 = new EasySet<int>(new int[] { 4, 5, 6, 7, 8 });
            var easySet3 = new EasySet<int>(new int[] { 1, 2, 3 });

            foreach(var item in easySet1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in easySet2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Usion");
            foreach (var item in easySet1.Union(easySet2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Intesection");
            foreach (var item in easySet1.Intersection(easySet2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Difference A \\ B");
            foreach (var item in easySet1.Difference(easySet2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Difference B \\ A");
            foreach (var item in easySet2.Difference(easySet1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(easySet3.SubSet(easySet1));

            Console.WriteLine();
            Console.WriteLine(easySet1.SubSet(easySet3));
            Console.WriteLine();

            Console.WriteLine(easySet2.SubSet(easySet3));

            Console.WriteLine();
            Console.WriteLine("SymmetricDifference");
            foreach (var item in easySet1.SymmetricDifference(easySet2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
        }
    }
}
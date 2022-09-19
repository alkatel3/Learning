namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Oleg", Age = 19, Gender = 0 };
            superHashTable.Add(person);
            superHashTable.Add(new Person() { Name = "Vitya", Age = 20, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Olya", Age = 19, Gender = 1 });
            superHashTable.Add(new Person() { Name = "Bodya", Age = 23, Gender = 0 });

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Oleg", Age = 19, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));
            Console.ReadLine();

            var badHashTable = new BadHashTable<int>(100);

            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(777);
            badHashTable.Add(7);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));
            Console.WriteLine(badHashTable.Search(5));
            Console.WriteLine(badHashTable.Search(7));
            Console.ReadLine();

            var HashTable = new HashTable<int, string>(100);

            HashTable.Add(5,"Hi");
            HashTable.Add(18,"World");
            HashTable.Add(777,"Hello");
            HashTable.Add(7, "Programmer");

            Console.WriteLine(HashTable.Search(6, "Vitaliy"));
            Console.WriteLine(HashTable.Search(18, "World"));
            Console.WriteLine(HashTable.Search(5,"Olya"));
            Console.WriteLine(HashTable.Search(7,"Programmer"));
        }
    }
}
using System;

namespace ConsoleApp27
{
    struct User
    {
        public string name;
        public int age;
        public void Add()
        {
            Console.WriteLine($"name={name}\nage={age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User Tom;
            Tom.age = 18;
            Tom.name = "Tom";
            Tom.Add();
            Console.ReadKey();
        }
    }
}
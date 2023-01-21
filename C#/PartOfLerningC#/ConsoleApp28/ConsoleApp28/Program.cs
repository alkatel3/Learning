using System;

namespace ConsoleApp28
{
    struct User
    {
        public int age;
        public string name;
        public User(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void Add()
        {
            Console.WriteLine($"age:{age}\n name:{name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                User Tom = new User(18, "Tom");
                Tom.Add();
            User Bob = new User();
            Bob.Add();
            Console.ReadKey();
        }
    }
}

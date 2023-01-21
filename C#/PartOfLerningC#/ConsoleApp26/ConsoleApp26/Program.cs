using System;

namespace ConsoleApp26
{
    class Person
    {
        public string name;
        public int age;
        public  Person() { name = "null"; age = 18; }
        public Person(string n){ name = n; age = 30; }
        public Person(string n, int a) { name = n; age = a; }
             public void Add()
        {
            Console.WriteLine($"name:{name}\n age:{age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person();
            Person Bob = new Person("Bob");
            Person Oleg = new Person("Oleg", 18);
            Tom.Add();
            Bob.Add();
            Oleg.Add();
            Console.ReadKey();
        }
    }
}

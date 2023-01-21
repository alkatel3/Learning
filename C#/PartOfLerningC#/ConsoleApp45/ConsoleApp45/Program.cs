using System;

namespace ConsoleApp45
{
    class Person
    {
        public string Name { get; set; }
    }
    class People
    {
        Person[] data;
        public People()
        {
            data = new Person[5];
        }
        // индексатор
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };

            Person tom = people[0];
            Console.WriteLine(tom.Name);

            Console.ReadKey(); 
        }
    }
}

    using System;
using System.Collections.Generic;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(5);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            numbers.Peek();
            foreach (var item in numbers)
            {
                Console.WriteLine("\t" + item);
            }
            numbers.Pop();
            foreach (var item in numbers)
            {
                Console.WriteLine("\t\t" + item);
            }
            numbers.Clear();
            Console.WriteLine("\t\t\t" + numbers.Count);
            var people = new Stack<Person>();
            people.Push(new Person() { Name = "Oleg" });
            people.Push(new Person() { Name = "Semen" });
            people.Push(new Person() { Name = "Taras" });
            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
            Person[] people1 = new Person[people.Count];
            people.CopyTo(people1,0);
            foreach (var item in people1)
            {
                Console.WriteLine("\t\t" + item.Name);
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
    }
}

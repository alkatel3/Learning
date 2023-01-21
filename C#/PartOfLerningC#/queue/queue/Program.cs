using System;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            for(int i = 1; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    numbers.Enqueue(i);
                }
            }
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.Write(numbers.Dequeue() +"\t");
            Console.Write(numbers.Dequeue() + "\t");
            Console.Write(numbers.Dequeue() + "\t");
            Console.Write(numbers.Dequeue() + "\t");
            Console.WriteLine(numbers.Dequeue());
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.Write(numbers.Peek() +"\t");
            Console.Write(numbers.Peek() + "\t");
            Console.WriteLine(numbers.Peek() + "\t");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            var people = new Queue<Person>();
            people.Enqueue(new Person() { Name="Oleg"});
            people.Enqueue(new Person() { Name = "Natasha" });
            people.Enqueue(new Person() { Name = "Semen" });
            foreach(var item in people)
            {
                Console.WriteLine(item.Name);
            }
            var person1 = people.Peek();
            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
            var person2 = people.Dequeue();
            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }
            people.Clear();
            Console.WriteLine(people.Count);
            Console.WriteLine(people.TryPeek(out Person person3));
        }

    }
    class Person 
    {
        public string Name { get; set; }
    }

}

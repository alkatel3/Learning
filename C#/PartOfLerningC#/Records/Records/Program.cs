using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person() { Name = "Tom" };
            //var person2 = new Person() { Name = "Tom" };
            //var person3 = person1 with { Age = 18 };
            //Console.WriteLine($"{person3.Name}-{person3.Age}");
            //Console.WriteLine(person1.Equals(person2));
            //Console.WriteLine(person1==person2);
            //var user1 = new User() { Name = "Tom" };
            //var user2 = new User() { Name = "Tom" };
            //Console.WriteLine(user1.Equals(user2));
            //Console.WriteLine(user1==user2);
            var person = new Person("Oleg", 17);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            var (UseName, UseAge) = person;
            Console.WriteLine(UseName);
            Console.WriteLine(UseAge);
        }
    }
//    public record Person
//    {
//        public string Name { get; init; }
//        public int Age { get; init; }
//    }
//    public class User
//    {
//        public string Name { get; init; }
//        public int Age { get; init; }
//    }
public record Person(string Name, int Age);
}

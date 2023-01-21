using System;

namespace destracte
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Oleg", Age = 17 };
            (string name,int age) = person;
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}

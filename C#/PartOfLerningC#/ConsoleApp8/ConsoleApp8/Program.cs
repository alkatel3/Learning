using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name:");
            string name = Console.ReadLine();
            Console.Write("Input your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            person(name,age);
        }
        static void person (string name,int age)
        {
            Console.WriteLine($"Your name:{name}\nYour age:{age}");
        }
    }
}

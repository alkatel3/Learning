using System;
using my_lib;
namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tom = new Person { name = "Tom", age = 18 };
            Console.WriteLine($"age={Tom.age}\n name={Tom.name}");

        }
    }
}

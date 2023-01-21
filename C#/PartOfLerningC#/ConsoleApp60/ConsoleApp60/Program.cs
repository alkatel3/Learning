using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Olenka = new Person("Olenka", "Moroz");
            Person Vasya = new Person("Vasya", "Pelenskiy");
            Console.WriteLine(Vasya.FoolName);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Vasya.run());
                Console.WriteLine(Olenka.run());
            }
        }
       
    }
}

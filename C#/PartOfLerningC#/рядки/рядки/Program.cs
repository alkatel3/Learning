using System;

namespace рядки
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a1 = "Hello";
            //string a2 = null;
            //string a3 = new String('a', 6);
            //string a4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            //Console.WriteLine($"{a1}\n{a2}\n{a3}\n{a4}");
            Console.WriteLine("Input name first user");
            var person1 = new Person(Console.ReadLine().Trim());
            Console.Clear();
            Console.WriteLine("Input name second user");
            var person2 = new Person(Console.ReadLine().Trim());
            Console.Clear();
            if (person1 == person2)
                Console.WriteLine("First user and second user have identical names");
            else
                Console.WriteLine("This users haven't identacal names");

            string text = "Хороший день";
            string subString = "замечательный ";

            text = text.Insert(8, subString);
            Console.WriteLine(text);
        }
    }
}

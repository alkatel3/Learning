using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 22, 11, 22, 345, 1, 2, 5, 3 };
            Array.Sort(numbers);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}

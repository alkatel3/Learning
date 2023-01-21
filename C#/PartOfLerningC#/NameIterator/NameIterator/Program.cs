using System;
using static System.Console;

namespace NameIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a starting value: ");
            int start = int.Parse(ReadLine());
            Write("Enter a finishing value: ");
            int end = int.Parse(ReadLine());
            NamedIterator nameIterator = new(end);

            Write("All values: ");
            foreach(int item in nameIterator)
            {
                Write($"{item} ");
            }
            Write("Values in set range: ") ;
            foreach (int item in nameIterator.GetRange(start))
            {
                Write($"{item} ");
            }
        }
    }
}

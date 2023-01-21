using System;
using System.Collections.Generic;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();
            while (list.Count < 5)
            {
                list.Add(Console.ReadLine());
            }
            int i = 0;
            while (i < list.Count)
            {
                Console.WriteLine(list[i]);
                i++;
            }
            Console.WriteLine("Hello World!");
        }
    }
}

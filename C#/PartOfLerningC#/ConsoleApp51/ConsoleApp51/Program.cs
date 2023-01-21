using System;
using System.Collections.Generic;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for(int i = 0; i< 10; i += 2)
            {
                list.Add(i);
            }
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i = 5; i < 30; i += 2)
            {
                list.Add(i);
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace lisT
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for(int i=20;i>0; i--)
            {
                list.Add(i);
            }
            foreach(var item in list)
            {
                Console.Write(list.IndexOf(item) + "\t");
                Console.WriteLine(item);
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.Write(list.IndexOf(item) + "\t");
                Console.WriteLine(item);
            }
            list.RemoveAt(10);
            foreach (var item in list)
            {
                Console.Write(list.IndexOf(item) + "\t");
                Console.WriteLine(item);
            }
        }
    }
}

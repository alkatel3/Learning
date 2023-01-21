using System;
using System.Collections.Generic;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"Input namber{i + 1}");
                list.Add(Convert.ToInt32(Console.ReadLine()));
                Console.Clear();
            }
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine($"sum={sum}");
            Console.ReadLine();
            Console.Clear();
            
            
            int dob = 1;
            int d = 0;
            do
            {
                dob *= list[d];
                    d++;
            }
            while (d < list.Count);
            Console.WriteLine(dob); 
            Console.ReadLine();
            Console.Clear();
           
            foreach(int Lis in list)
            {
                Console.Write($"{Lis}\t");  
            }
        }
    }
}

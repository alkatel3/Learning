using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Group1 = new ArrayList();
            ArrayList Group2 = new ArrayList();
            for (int i = 1; i <= 50; i++)
            {
                if (i <= 25)
                {
                    Group1.Add("Student" + i);
                }
                else
                {
                    Group2.Add("Student" + i);
                }
            }
            
            string Name = "Oleg";
            
            string Name1 = "Olena";
            
            //foreach (var i in Group1)
            //{
            //    Console.Write(Group1.IndexOf(i)+1+"\t");
            //    Console.WriteLine(i);                
            //}
            //foreach (var i in Group2)
            //{
            //    Console.Write(Group2.IndexOf(i)+ 1 + "\t");
            //    Console.WriteLine(i);
            //}
            Group1.Clear();
            Console.WriteLine(Group1.Contains("Student26"));
            Group1.AddRange(Group2);
            Console.WriteLine(Group1.Contains("Student26"));
            foreach (var i in Group1)
            {
                Console.Write(Group1.IndexOf(i) + 1 + "\t");
                Console.WriteLine(i);
            }
            var Group = new string[25];
            Group1.CopyTo(Group);
            foreach(var i in Group)
            {
                Console.WriteLine(i);
               
            }
            Console.WriteLine(Group2.LastIndexOf("Student26"));
            Group1.Reverse();
            foreach (var i in Group1)
            {
                Console.Write(Group1.IndexOf(i) + 1 + "\t");
                Console.WriteLine(i);
            }
            Console.Write(Group1.Count);
        }
    }
}

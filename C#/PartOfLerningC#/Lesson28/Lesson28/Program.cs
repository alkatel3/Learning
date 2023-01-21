using System;

namespace Lesson28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            for(int i = 0; i < 10000; i++)
            {                
                var obj = (object)i;
                int j = (int)obj;

            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.ReadKey();
        }
    }
}

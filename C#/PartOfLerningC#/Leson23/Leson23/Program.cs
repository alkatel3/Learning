using System;

namespace Leson23
{
    class Program
    {
        static void Main(string[] args)
        {
           Tuple<int, string> tuple= new Tuple<int, string>(666, "JS");
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            var tuple2 = (18, "js");// анальгічний запис

        }
    }
}

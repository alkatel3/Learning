using System;
using System.Threading;
namespace ThreadPriority
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(Method);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Priority = System.Threading.ThreadPriority.Highest;
            t2.Priority = System.Threading.ThreadPriority.Lowest;
            t2.Start("\t\t\t2");
            t1.Start("t1");
            Console.ReadKey();
        }
        static void Method(object str)
        {
            string text = (string)str;
            for(int i=0; i < 500; i++)
            {
                Console.WriteLine("{0} #{1}",text,i.ToString());
            }
        }
    }
}

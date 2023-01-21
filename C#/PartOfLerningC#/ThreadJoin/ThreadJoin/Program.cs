using System;
using System.Threading;

namespace ThreadJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart TS = new ThreadStart(Method);
            Thread T = new Thread(TS);
            Console.WriteLine("Thread will be launch now");
            T.Start();
            Thread.Sleep(200);
            Console.WriteLine("Waiting finish of thread working");
            T.Join();
            Console.WriteLine("Program finished");
        }
        static void Method()
        {
            Console.WriteLine("Thread works");
            Thread.Sleep(2000);
            Console.WriteLine("Thread finished");
        }
    }
}

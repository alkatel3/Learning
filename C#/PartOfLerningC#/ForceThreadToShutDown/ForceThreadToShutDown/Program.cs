using System;
using System.Threading;

namespace ForceThreadToShutDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.IsBackground=true;
            t.Start();
            Thread.Sleep(1000);
        }
        static void Method()
        {
            try
            {
                for(int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i.ToString());
                    if (i == 50)
                    {
                        Thread t = Thread.CurrentThread;
                        t.Abort();
                    }
                }
            }
            finally
            {
                Console.WriteLine("End Thread Work");
            }
        }
    }
}

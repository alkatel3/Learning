using System.Diagnostics;

namespace UsingProcess_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "List of Process" ;
            Console.WindowWidth = 39;
            Console.BufferWidth = 39;

            Process[] processes = Process.GetProcesses();
           Console.WriteLine("{0,-28}{1,-10}","Process name:","PID:");
            foreach(var process in processes)
            {
                Console.WriteLine("{0,-28}{1,-10}",process.ProcessName, process.Id);
            }
        }
    }
}
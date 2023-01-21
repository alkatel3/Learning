using System.Diagnostics;

namespace UsingProcess_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process proc = new();
            proc.StartInfo.FileName = "notepad.exe";
            proc.Start();
            Console.WriteLine("running process " + proc.ProcessName);
            proc.WaitForExit();
            Console.WriteLine("Process exited with code: " + proc.ExitCode);
            Console.WriteLine("Current process name: " + Process.GetCurrentProcess().ProcessName);
        }
    }
}
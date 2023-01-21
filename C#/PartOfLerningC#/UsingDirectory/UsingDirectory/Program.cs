using System;
using System.IO;
using static System.Console;

namespace UsingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path= @"C:\Users\Dell\source\repos\dir";
            if (Directory.Exists(path))
            {
                WriteLine($"Date and time of catalog creation: " +
                    $"{Directory.GetCreationTime(path)}");
                WriteLine("\nSubdirectories in the specified directory:");
                foreach(var item in Directory.GetDirectories(path))
                {
                    WriteLine($"\t{item}");
                }
                WriteLine("\nLogical devices of this computer:");
                foreach(var item in Directory.GetLogicalDrives())
                {
                    WriteLine($"\t{item}");
                }
                Directory.Delete(path, true);
            }
            else
            {
                WriteLine("\nSpecified directory does not exist.\n");
            }
        }
    }
}

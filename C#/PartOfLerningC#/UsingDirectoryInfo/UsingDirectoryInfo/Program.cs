using static System.Console;
using System.IO;

namespace UsingDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            WriteLine($"Full path to the directory:\n{dir.FullName}");
            WriteLine($"Time of creation: {dir.CreationTime}");
            WriteLine("\n\tAll directory files:");
            FileInfo[] files = dir.GetFiles();
            foreach(var file in files)
            {
                WriteLine(file.Name);
            }
            WriteLine();
        }
    }
}

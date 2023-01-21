using System;
using System.IO;
using static System.Console;

namespace UsingDirectoryInfoAndFileInfo
{
    class Program
    {
        static void WriteFile(FileInfo f)
        {
            using (FileStream fs = f.Open(FileMode.Create, FileAccess.Write, FileShare.None))
            {
                WriteLine("\nEnter the data to write to the file");
                string writeText = ReadLine();
                byte[] writeBytes = System.Text.Encoding.Default.GetBytes(writeText);
                fs.Write(writeBytes, 0, writeBytes.Length);
                WriteLine("\nData recorded!\n");
            }
        }
        
        static string ReadFile(FileInfo f)
        {
            using (FileStream fs = f.OpenRead())
            {
                byte[] readByte = new byte[(int)fs.Length];
                fs.Read(readByte, 0, readByte.Length);
                return System.Text.Encoding.Default.GetString(readByte);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new(@"C:\Users\Dell\source\repos");
            if (!dir.Exists)
            {
                dir.Create();
            }
            WriteLine($"Last access time to the directory: {dir.LastAccessTime}");
            DirectoryInfo dir1 = dir.CreateSubdirectory("Subdir1");
            WriteLine($"Full path to the directory:\n{dir1.FullName}");
            FileInfo fInfo = new(dir1 + @"\Test.txt");
            WriteFile(fInfo);
            WriteLine(ReadFile(fInfo));
            WriteLine($"\n\tOnly files with the extension '.txt':");
            FileInfo[] files = dir1.GetFiles("*.txt");

            foreach(FileInfo f in files)
            {
                WriteLine(f.Name);
            }
            Console.WriteLine();
        }
    }
}

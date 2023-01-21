using System;
using System.IO;
using System.Text;
using static System.Console;

namespace UsingFileStream
{
    class Program
    {
        static void WriteFile(string filePath)
        {
            using(FileStream fs=new FileStream(filePath,
                FileMode.Create, FileAccess.Write,
                FileShare.None))
            {
                WriteLine("Enter the data to write to the file:");
                string writeText = ReadLine();
                byte[] writeBytes = Encoding.Default.GetBytes(writeText);
                fs.Write(writeBytes, 0, writeBytes.Length);
                WriteLine("Information recorded");
            }
        }
        static string ReadFile(string filePath)
        {
            using(FileStream fs=new FileStream (filePath,
                FileMode.Open,FileAccess.Read,
                FileShare.Read))
            {
                byte[] readBytes = new byte[(int)fs.Length];
                fs.Read(readBytes, 0, readBytes.Length);
                return Encoding.Default.GetString(readBytes);
            }
        }
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            WriteFile(filePath);
            WriteLine($"\nData read from the file: " +
                $"{ReadFile(filePath)}");
        }
    }
}

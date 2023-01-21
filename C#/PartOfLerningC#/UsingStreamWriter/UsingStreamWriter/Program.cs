using System;
using System.IO;
using static System.Console;

namespace UsingStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";

            using (FileStream fs = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(StreamWriter sw = new(fs, System.Text.Encoding.Unicode))
                {
                    WriteLine("Enter data to write to the file:");
                    string writeText = ReadLine();
                    sw.WriteLine(writeText);
                    foreach(var item in writeText)
                    {
                        sw.Write($"{item} ");
                    }
                    WriteLine("\nData recorded");
                }
            }
        
        }
    }
}

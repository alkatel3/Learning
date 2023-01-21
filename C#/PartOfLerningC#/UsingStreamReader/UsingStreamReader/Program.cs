using System;
using System.IO;

namespace UsingStreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "test.txt";
            using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new(filePath, System.Text.Encoding.Default))
                {
                    Console.WriteLine($"Data read from the file:\n");
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
        }
    }
}

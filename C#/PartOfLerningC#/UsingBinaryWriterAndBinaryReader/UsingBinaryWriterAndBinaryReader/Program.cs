using System;
using System.IO;

namespace UsingBinaryWriterAndBinaryReader
{
    class Program
    {
        static void FileWrider(string filePath)
        {
            using(FileStream fs = new(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(BinaryWriter bw = new(fs, System.Text.Encoding.Unicode))
                {
                    Console.WriteLine("Enter data to write to the file:");
                    string writeText = Console.ReadLine();
                    double pi = Math.PI;
                    int Number = 8092002;
                    bw.Write(writeText);
                    bw.Write(pi);
                    bw.Write(Number);

                    Console.WriteLine("\nData recorded!");
                }
            }
        }
        
        static void FileReader(string filePath)
        {
            using(FileStream fs = new(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using(BinaryReader br = new(fs, System.Text.Encoding.Unicode))
                {
                    Console.WriteLine("Data read from the file:\n");
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadDouble());
                    Console.WriteLine(br.ReadInt32());
                }
            }
        }

        static void Main(string[] args)
        {
            string filePath = "test.txt";
            FileWrider(filePath);
            FileReader(filePath);
        }
    }
}

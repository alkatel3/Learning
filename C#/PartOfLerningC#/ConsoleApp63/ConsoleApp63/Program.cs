using System;
using System.IO;
using System.Text;

namespace Lesson16
    {
    class Program
    {

        static void Main(string[] args)
        {
           ;
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Input Information!");

                var info = Console.ReadLine();
                using (StreamWriter sw = new StreamWriter("Olya.txt", true,Encoding.UTF8))
                {
                    sw.WriteLine($"{info};")  ;

                }
                Console.WriteLine("Added to the file;");
                using (StreamReader sr = new StreamReader("Olya.txt",Encoding.UTF8))
                {

                    Console.WriteLine($"Is in the file:\n { sr.ReadToEnd()}");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }

    }
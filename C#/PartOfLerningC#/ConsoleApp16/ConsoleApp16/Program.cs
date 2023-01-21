using System;

namespace ConsoleApp16
{
    class Program
    {
        static int a = 10;
        static void Main(string[] args)
        {
            int b = a - 2;
            Console.WriteLine(b);
           // Console.WriteLine(c); не працює бо дана змінна викликається не в даному блоці коду
           // Console.WriteLine(d); не працює бо дана змінна викликана не в даному методі
            {
                int c = 10 - 3;
                Console.WriteLine(c);
                Console.WriteLine(b);
                // Console.WriteLine(d); не працює бо дана змінна викликана не в даному методі
            }
        }
        void metod()
        {
           int d =a+ 10;
            Console.WriteLine(d);
            //Console.WriteLine(c); не працює бо дана змінна викликана не в даному методі
            //Console.WriteLine(b); не працює бо дана змінна викликана не в даному методі
        }
    }
}

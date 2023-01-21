using System;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            
            pupils Olya = new pupils();
            Olya.name = "Olya";
            Olya.perents = 2;
            Olya.age = 16;
            Olya.form = 11;
            People_in_school Oleg = Olya;
            pupils Oleg1 = (pupils)Oleg;
            Console.WriteLine(Oleg1.name);
        }
    }
}

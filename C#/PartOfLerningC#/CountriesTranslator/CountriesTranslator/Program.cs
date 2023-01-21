using System;
using static System.Console;

namespace CountriesTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string country;
            FullerTranslators.AddCountry();
            WriteLine("Choose a translation direction:\n" +
                "1. UA->UK\n" +
                "2. UK->UA\n" +
                "Enter number 1 or 2: ");

            if (int.Parse(ReadLine()) == 1)
            {
                Clear();
                Write("Enter your country: ");
                 country = ReadLine();
                WriteLine(TranslatorFromUA.Countries[country]);
            }
            else
            {
                Clear();
                Write("Enter your country: ");
                 country = ReadLine();
                WriteLine(TranslatorFromUK.Countries[country]);
            }
        }
    }
}

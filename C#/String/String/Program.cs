using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            string str = GetString();
            Console.WriteLine($"Total count: {str.Length}\n" +
                $"Space count: {SpaceCount(str)}\n" +
                $"Number count: {NumberCount(str)}\n" +
                $"Punctuation count: {PunctuationCount(str)}\n" +
                $"Letter count: {LetterCount(str)}");

        }
        static string GetString()
        {
            Console.WriteLine("Enter some string");
            string str = Console.ReadLine();
            return str;
        }
        static int SpaceCount(string str)
        {
            int count = 0;
            foreach(char item in str)
            {
                if (Char.IsWhiteSpace(item))
                {
                    count++;
                }
            }
            return count;
        }
        static int NumberCount(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (Char.IsNumber(item))
                {
                    count++;
                }
            }
            return count;
        }
        static int PunctuationCount(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (Char.IsPunctuation(item))
                {
                    count++;
                }
            }
            return count;
        }
        static int LetterCount(string str)
        {
            int count = 0;
            foreach (char item in str)
            {
                if (Char.IsLetter(item))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Task1();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task2();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task3();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task4();
            Console.WriteLine(new String('.', Console.BufferWidth));
            Task5();
            Console.WriteLine(new String('.', Console.BufferWidth));

        }
        static void Task5()
        {
            string str = GetString();
            string[] words = str.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for(int i =0;i<words.Length;i++)
                for(int j=0;j< words[i].Length;j++)
                    if (CountOfLetter(words[i], words[i][j]) > 1)
                    {
                       words[i]= words[i].Remove(words[i].LastIndexOf(words[i][j]), 1);
                    }
            str = String.Join(' ', words);
            Console.WriteLine(str);
        }
        static int CountOfLetter(string word, char letter)
        {
            int count = 0;
            foreach(var item in word)
            {
                if (item == letter)
                {
                    count++;
                }
            }
            return count;
        }
        static void Task4()
        {
            string str = GetString();
            string[] words = str.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = RemoveRepeatLetters(words[i]);
            }
            str = String.Join(' ', words);
            Console.WriteLine(str);
        }
        static string RemoveRepeatLetters(string word)
        {
            char FirstSymbol = word[0];
            for(int i = 1; i < word.Length; i++)
            {
                if (word[i] == FirstSymbol)
                {
                   word=word.Remove(i, 1);
                }
            }
            return word;
        }
        static void Task3()
        {
            string str = GetString();
            string[] words = str.Split(new char[] { ' ' });
            words = RemoveRepeatWords(words);
            str = String.Join(' ', words);
            Console.WriteLine(str);
        }
        static string[] RemoveRepeatWords(string[] words)
        {
            bool one = true;
            for(int i = 0; i < words.Length; i++)
            {
                for(int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        words[j] = null;
                        one = false;
                    }
                }
                if (!one)
                {
                    one = true;
                    words[i] = null;
                }
            }
            return words;
        }
        static void Task2()
        {
            string str = GetString();
            char ch = GetChar();
            char NewCh = char.ToUpper(ch);
            int count= FoundSymbol(ch, str);
            Console.WriteLine($"In string \"{str}\" is {count} of \'{ch}\'");
            str=str.Replace(ch, NewCh);
            Console.WriteLine($"New string \"{str}\"");
            str=str.Remove(str.LastIndexOf(NewCh));
            Console.WriteLine($"New string \"{str}\"");
        }
        static int FoundSymbol(char ch, string str)
        {
            int count = 0;
            foreach(var item in str)
            {
                if(item == ch)
                {
                    count++;
                }
            }
            Console.WriteLine($"In string \"{str}\" is {count} of \'{ch}\'");
            return count;
        }
        static void Task1()
        {
            string str = GetString();
            Console.WriteLine($"Total count: {str.Length}\n" +
                $"Space count: {SpaceCount(str)}\n" +
                $"Number count: {NumberCount(str)}\n" +
                $"Punctuation count: {PunctuationCount(str)}\n" +
                $"Letter count: {LetterCount(str)}");
        }
        static char GetChar()
        {
            Console.WriteLine("Enter some string");
            char ch = Char.Parse(Console.ReadLine());
            return ch;
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

using System;

namespace extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "hello world";
            char letter = 'o';
            int i = word.CharConst(letter);
            Console.WriteLine(i);
            Console.ReadLine();
        }    
    }
    public static class StringExtension
    {
        public static int CharConst (this string word, char letter)
        {
            int conter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                    conter++;
            }
            return conter;
        }
    }
   
    
    
}

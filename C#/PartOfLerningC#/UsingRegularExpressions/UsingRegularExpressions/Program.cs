using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace UsingRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
            Write("Enter e-mail: ");
            string email = ReadLine();
            Regex regex= new Regex(emailPattern);
            WriteLine(regex.IsMatch(email) ? "E-mail confirmed " : "Incorrect e-mail!");
            string phonePattern = @"^\+\d{ 2}\(\d{ 3\)\d{ 3}-\d{ 2}-\d{ 2}$";
            Write("Enter phone: ");
            string phone = ReadLine();
            regex = new Regex(phonePattern);
            WriteLine(regex.IsMatch(email) ? "Data receiver." : "Data is not correct!");
            WriteLine("\nReplacement of words matching a pattern");
            string text = "I like Java. Java forever";
            string textPattern = "Java";
            WriteLine(text);
            WriteLine(Regex.Replace(text, textPattern, "C#"));
        }
    }
}

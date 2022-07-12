using System;
using System.ComponentModel;
using static System.Console;

namespace Event_
{
    class Program
    {
        public static void Test(object sender, PropertyChangedEventArgs e)
        {
            WriteLine($"Changed property {e.PropertyName}");
        }
        static void Main(string[] args)
        {
            Author author = new("Erich", "Remarque", 15);
            author.PropertyChanged += Test;
            author.FirstName = "Erich Maria";

            Client client = new("Oleg", "Yovyk", "0000000000");
            client.PropertyChanged += Test;
            client.Phone = "11111111";
        }
    }
}

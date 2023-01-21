using System;

namespace Event
{
    class Program
    {

        static void Main(string[] args)
        {
            
            var client = new Account(200);
            //client.Text += Message;
            //client.Text += ColorMessage;
            
            client.Add(200);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"На вашому рахунку: {client.Sum}");
            Console.ResetColor();
            client.Take(100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"На вашому рахунку: {client.Sum}");
            Console.ResetColor();
            client.Text -= Message;
            client.Take(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"На вашому рахунку: {client.Sum}");
            Console.ResetColor();
            Console.ReadKey();
        }
        static void Message (object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }
        static void ColorMessage(string mes)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mes);
            Console.ResetColor();
        }
    }
}

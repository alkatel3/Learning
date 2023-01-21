using System;

namespace Delegate
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
           
            
            Account account = new Account(100);
            account.RegisterHandler(Display);
            account.RegisterHandler(ColorDisplay);
            account.put(100);
            account.Withdraw(100);
            account.UnregisterHandler(ColorDisplay);
            account.Withdraw(200);
        }
 static void Display(string message)
        {
            Console.WriteLine(message);
        }
        static void ColorDisplay(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

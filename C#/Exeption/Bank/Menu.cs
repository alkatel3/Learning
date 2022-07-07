using System;

namespace Bank
{
    static class Menu
    {
        public static void Start()
        {
            try
            {
                Money money = CreateBalance();
                AskAddSum(money);
                AskSubtractSum(money);
                OperationWithMoney(money);
            }
            catch(Bankrut be)
            {
                Console.WriteLine(be.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(fe.Message); 
            }
            catch (OverflowException ofe)
            {
                Console.WriteLine(ofe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ChooseEvent(Money money)
        {
            Console.WriteLine("Choose what do you want do with you money:(click letter a or b)\n" +
                "a).Add money;\n" +
                "b)Subtract money;");
            char letter = Console.ReadLine()[0];
            if (letter == 'a')
            {
                AskAddSum(money);
            }
            else if (letter == 'b')
            {
                AskSubtractSum(money);
            }
            else
            {
                Console.WriteLine("Incorect input");
            }
        }
         static Money CreateBalance()
        {
            Console.WriteLine("Enter sum of your money (first hryvnias and then pennies)");
            Console.WriteLine("Enter how many hryvnias are you have (integer)");
            long hryvnias = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many pennies are you have (integer)");
            long pennies = Int64.Parse(Console.ReadLine());
            Money money= new Money(hryvnias, pennies);
            Console.WriteLine(money);
            return money;
            
        }
        static void AskAddSum(Money money)
        {
            Console.WriteLine("Enter how many money do you want add (first hryvnias and then pennies)");
            Console.WriteLine("Enter how many hryvnias do you want add (integer)");
            long hryvnias = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many pennies do you want add (integer)");
            long pennies = Int64.Parse(Console.ReadLine());
            money.AddMoneyToBalance(hryvnias, pennies);
            Console.WriteLine(money);
        }
        static void AskSubtractSum(Money money)
        {
            Console.WriteLine("Enter how many money do you want subtract (first hryvnias and then pennies)");
            Console.WriteLine("Enter how many hryvnias do you want subtract (integer)");
            long hryvnias = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many pennies do you want subtract (integer)");
            long pennies = Int64.Parse(Console.ReadLine());
            money.SubtractMoneyFromBalance(hryvnias, pennies);
            Console.WriteLine(money);
        }
        static void OperationWithMoney(Money money)
        {
            Money money2 = new(100, 123);
            int number = 7;
            Console.WriteLine($"{nameof(money2)} = {money2}");
            Console.WriteLine($"{nameof(money)}+{nameof(money2)}={money + money2}");
            Console.WriteLine($"{nameof(money)}-{nameof(money2)}={money - money2}");
            Console.WriteLine($"{nameof(money)}*{number}={money / number}");
            Console.WriteLine($"{nameof(money)}/{number}={money /number}");
            Console.WriteLine($"{nameof(money)}++={money++}");
            Console.WriteLine($"{nameof(money)}--={money--}");
            if (money > money2)
            {
                Console.WriteLine($"{nameof(money2)}-{nameof(money)}={money2 - money}");
            }
            Console.WriteLine(money);
        }
    }
}

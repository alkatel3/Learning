using System;

namespace ConsoleApp40
{
    class User
    {
        static User()
        {
            Console.WriteLine("Создан первый пользователь");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(); // здесь сработает статический конструктор
            User user2 = new User();

            Console.Read();
        }
    }
}

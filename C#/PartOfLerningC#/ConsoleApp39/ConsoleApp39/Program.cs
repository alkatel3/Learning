using System;

namespace ConsoleApp39
{
    class user
    {
        private static int counter=0;
        public user()
        {
            counter++;
        }
        public static void number()
        {
            Console.WriteLine($"number = {counter}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            user user1 = new user();
            user user2 = new user();
            user user3 = new user();
            user user4 = new user();
            user user5 = new user();
            user user6 = new user();
            user.number();
        }
    }
}

using System;
using System.Threading;
using static System.Console;

namespace ThreadPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart Lis = new ThreadStart(LisenerClient);
            Thread LisenerThread = new Thread(Lis);
            LisenerThread.Start();
        }
        static void LisenerClient()
        {
            int Counter =0;
            while (true)
            {
                WriteLine("Press any button to simulation connection");
                ReadKey(true);
                ParameterizedThreadStart UserDel = new ParameterizedThreadStart(UserThreadFunk);
                Thread UserWorkThread=new Thread(UserDel);
                UserWorkThread.Start(Counter.ToString());
                Counter++;
            }
        }
        static void UserThreadFunk(object a) 
        {
            string UserName=(string) a;
            WriteLine("User\t# " + UserName + "connected");
           
            while(true)
            {
                switch (GetUserCommand())
                {
                    case 0:
                        WriteLine("# {0} subscribed to news", UserName);
                        break;
                    case 1:
                        WriteLine("# {0} began chat", UserName);
                        break;
                    case 2:
                        WriteLine("# {0} sent letter", UserName);
                        break;
                    case 3:
                        WriteLine("# {0} bought products at shop", UserName);
                        break;
                    case 4:
                        WriteLine("# {0} disconnected", UserName);
                        return;  
                }


            }
        }
        static int GetUserCommand()
        {
            WriteLine("Enter number what do you want to do");
            WriteLine("0. subscribed to news");
            WriteLine("1. began chat");
            WriteLine("2. sent letter");
            WriteLine("3. bought products at shop");
            WriteLine("4. disconnected");
            switch (ReadKey().Key)
            {
                case ConsoleKey.D0:
                    return 0;
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.D4:
                    return 4;
                default:
                    return 4;
            }

        }
    }
}

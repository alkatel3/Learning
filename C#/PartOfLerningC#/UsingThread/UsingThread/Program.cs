namespace UsingThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadWithoutParams();
            ThreadWithParams();
        }
        
        static void ThreadWithoutParams()
        {
            ThreadStart threadStart = new ThreadStart(Method);
            Thread thread = new Thread(threadStart);
            thread.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Hello in main");
            }
        }
        static void Method()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("\t\t\tHello in thread");
            }
        }


        static void ThreadWithParams()
        {
            ParameterizedThreadStart threadStart = 
                new ParameterizedThreadStart(ThreadFunk);
            Thread thread1=new Thread(threadStart);
            thread1.Start("One");
            Thread thread2=new Thread(threadStart);
            thread2.Start("\t\tTwo");
        }
        static void ThreadFunk(object a)
        {
            string ID = (string)a;
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(ID);
            }
        }
    }
}
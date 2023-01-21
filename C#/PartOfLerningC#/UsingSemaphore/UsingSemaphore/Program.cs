namespace UsingSemaphore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaphore s = new Semaphore(3, 3, "My_Semaphore");
            for(int i = 0; i < 6; i++)
            {
                ThreadPool.QueueUserWorkItem(SomeMethod, s);
            }
            Console.ReadKey();
        }
        static void SomeMethod(object obj)
        {
            Semaphore s=obj as Semaphore;
            bool stop=false;

            while (!stop)
            {
                if (s.WaitOne(500))
                {
                    try
                    {
                        Console.WriteLine("Thread {0} was blocked", Thread.CurrentThread.ManagedThreadId);
                        Thread.Sleep(2000);
                    }
                    finally
                    {
                        stop = true;
                        s.Release();
                        Console.WriteLine("Thread {0} wasn't blocked",Thread.CurrentThread.ManagedThreadId);
                    }
                }
                else
                {
                        Console.WriteLine("Timeout for thread {0} is over. Again waiting",Thread.CurrentThread.ManagedThreadId);
                }
            }
        }
    }
}
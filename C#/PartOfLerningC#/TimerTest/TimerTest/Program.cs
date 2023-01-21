namespace TimerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(TimerMethod, null, 0, 1000);

            Console.WriteLine("Main thread {0} continue", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            timer.Dispose();
        }
        static void TimerMethod(object obj)
        {
            Console.WriteLine("Thread {0} : {1}",Thread.CurrentThread.ManagedThreadId,DateTime.Now);
        }

    }
}
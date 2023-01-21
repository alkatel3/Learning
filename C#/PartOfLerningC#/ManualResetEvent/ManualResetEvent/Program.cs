namespace UsingManualResetEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsingManualResetEventMethod();
            UsingAutoResetEventMethod();
        }
        static void UsingManualResetEventMethod()
        {
            Console.WriteLine("Manual reset event");

            ManualResetEvent mre = new ManualResetEvent(true);

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(SomeMethod, mre);
            }
            Console.ReadKey();
        }
        static void UsingAutoResetEventMethod()
        {
            Console.WriteLine("Auto Reset Event");

            AutoResetEvent mre = new AutoResetEvent(true);

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(SomeMethod, mre);
            }
            Console.ReadKey();
        }
        static void SomeMethod(object obj)
        {
            EventWaitHandle ev=obj as EventWaitHandle;
            if (ev.WaitOne(100))
            {
                Console.WriteLine("Thread {0} managed to slip through",Thread.CurrentThread.ManagedThreadId);
                ev.Reset();
            }
            else
            {
                Console.WriteLine("Thread {0} lated", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
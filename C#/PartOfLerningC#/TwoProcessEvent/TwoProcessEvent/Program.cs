namespace TwoProcessEvent
{
    internal class Program
    {
        static EventWaitHandle canCalc;
        static int result;

        static void Main(string[] args)
        {
            try
            {
                canCalc = EventWaitHandle.OpenExisting("PROCESS_EVENT");
                canCalc.Set();
                result = 2;
            }
            catch (WaitHandleCannotBeOpenedException ex)
            {
                canCalc = new EventWaitHandle(false,
                    EventResetMode.AutoReset, "PROCESS_EVENT");
                result = 1;
                Console.WriteLine("Run the second instance of the program");
            }
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            Console.ReadKey();
        }
        static void ThreadMethod(object obj)
        {
            canCalc.WaitOne();
            Thread.Sleep(1000);
            Console.WriteLine("Thread {0}: Result = {1}", Thread.CurrentThread.ManagedThreadId, result);

            result += 2;
            canCalc.Set();
            Thread.Sleep(1000);
            if (result <= 10)
            {
                ThreadPool.QueueUserWorkItem(ThreadMethod);
            }
        }
    }
}
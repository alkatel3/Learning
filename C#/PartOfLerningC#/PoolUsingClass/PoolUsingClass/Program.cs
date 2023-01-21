namespace PoolUsingClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main thread: Set working element");
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
                ThreadPool.QueueUserWorkItem(WorkingElementMethod, random.Next(10));
            Console.WriteLine("Main thread: executes other tasks");
            Thread.Sleep(1000);
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }
        private static void WorkingElementMethod(object state)
        {
            Console.WriteLine("\tthread: {0} state = {1}", Thread.CurrentThread.ManagedThreadId, state);
            Thread.Sleep(1000);
        }
    }
}
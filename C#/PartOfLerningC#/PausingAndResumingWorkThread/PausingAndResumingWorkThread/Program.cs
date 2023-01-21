namespace PausingAndResumingWorkThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread thread = new Thread(ts);
            thread.Start();
            Console.WriteLine("PressAnyButtonToStop");
            Console.ReadKey();
            thread.Suspend();
            Console.WriteLine("Thread is suspended");
            Console.WriteLine("Press any button to resume");
            Console.ReadKey();
            thread.Resume();
        }
        static void Method()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
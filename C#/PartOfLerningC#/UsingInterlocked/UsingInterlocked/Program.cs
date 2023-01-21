namespace UsingInterlocked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for(int i = 0; i < threads.Length; ++i)
            {
                threads[i] = new Thread(delegate ()
                {
                    for (int j = 1; j <= 1000000; ++j)
                    {
                        Interlocked.Increment(ref Counter.counter);
                    }
                });
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; ++i)
            {
                threads[i].Join();
            }
            Console.WriteLine("Counter = " + Counter.counter);
        }
        class Counter
        {
           public static int counter;
        }
    }
}
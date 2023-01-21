namespace UsingMutex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchronization with a mutex:");
            MutexCounter counter=new MutexCounter();
            Thread[] threads = new Thread[5];
            for(int i =0; i<threads.Length; i++)
            {
                threads[i]= new Thread(counter.UpdateCount);
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine("Count: " + counter.Count);

        }
        class MutexCounter
        {
            int count;
            Mutex mutex = new Mutex();
            public int Count
            {
                get { return count; }
            }
            public void UpdateCount()
            {
                for(int i = 0; i < 1000000; i++)
                {
                    mutex.WaitOne();
                    Console.WriteLine("Current valur: " + count);
                    count++;
                    mutex.ReleaseMutex();
                }
            }

        }
    }
}
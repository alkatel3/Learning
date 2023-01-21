namespace DeadLock
{
    internal class DeadLockClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sync static type:");
            LockCounter counter = new LockCounter();
            Monitor.Enter(counter);
            Thread[] threads=new Thread[5];
            for(int i=0; i<threads.Length; i++)
            {
                threads[i] = new Thread(counter.UpdateCounter);
                threads[i].Start();
            }
            for(int i=0; i<threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("Counter: {0}\n\n", counter.Counter);
        }
        ~DeadLockClass()
        {
            lock (this)
            {
                Console.WriteLine("Writing log-file");
            }
        }
    }
    class LockCounter
    {
        int counter;
        object lockObj = new object();

        public int Counter
        {
            get { return counter; }
        }
        public void UpdateCounter()
        {
            for(int i = 0; i < 1000000; i++)
            {
                lock (lockObj)
                {
                    counter++;
                }
            }
        }
    }
}
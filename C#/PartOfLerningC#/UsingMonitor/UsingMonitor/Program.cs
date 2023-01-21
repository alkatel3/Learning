namespace UsingMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            BadAsyncUsingInterlocked();
            GoodAsyncUsingFullMonutor();
            GoodAsyncUsingLock();
            GoodAsyncUsingLockForStatic();
        }
        private static void BadAsyncUsingInterlocked()
        {
            Console.WriteLine("Sync Interlocked Methods:");
            InterlockCounter c= new InterlockCounter();

            Thread[] threads = new Thread[5];

            for(int i=0; i<threads.Length; i++)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine("Field1: {0}, Field2: {1}\n\n", c.Field1, c.Field2);
        }
        private static void GoodAsyncUsingFullMonutor()
        {
            Console.WriteLine("Sync blocking1:");
            MonitorLockCounte c=new MonitorLockCounte();

            Thread[] threads=new Thread[5];
            for(int i=0; i<threads.Length; i++)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine("Field1: {0}, Field2: {1}\n\n",c.Field1,c.Field2);
        }
        private static void GoodAsyncUsingLock()
        {
            Console.WriteLine("Sync blocking2:");
            LockCounte c = new LockCounte();

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(c.UpdateFields);
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine("Field1: {0}, Field2: {1}\n\n", c.Field1, c.Field2);
        }
        private static void GoodAsyncUsingLockForStatic()
        {
            Console.WriteLine("Sync blocking3:");

            Thread[] threads = new Thread[5];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(StaticLockCounte.UpdateFields);
                threads[i].Start();
                threads[i].Join();
            }
            Console.WriteLine("Field1: {0}, Field2: {1}\n\n", StaticLockCounte.Field1, StaticLockCounte.Field2);
        }
    }
    class InterlockCounter
    {
        int field1;
        int field2;
        public int Field1
        {
            get { return field1; }
        }
        public int Field2
        {
            get { return field2; }
        }
        public void UpdateFields()
        {
            for(int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref field1);
                if (field1 % 2 == 0)
                {
                    Interlocked.Increment(ref field2);
                }
            }
        }
    }
    class MonitorLockCounte
    {
        int field1;
        int field2;
        public int Field1
        {
            get { return field1; }
        }
        public int Field2
        {
            get { return field2; }
        }
        public void UpdateFields()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(this);
                try
                {
                    field1++;


                    if (field1 % 2 == 0)
                    {
                        field2++;
                    }
                }
                finally
                {
                    Monitor.Exit(this);
                }
            }
        }
    }
    class LockCounte  //Easier way for using Monitor
    {
        int field1;
        int field2;
        public int Field1
        {
            get { return field1; }
        }
        public int Field2
        {
            get { return field2; }
        }
        public void UpdateFields()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (this) //Implicit Monitor.Enter(this)
                {
                    field1++;
                    if (field1 % 2 == 0)
                    {
                        field2++;
                    } //Implicit Monitor.Exit(this)
                }
            }
        }
    }

    static class StaticLockCounte  //Example using static elements for lock()
    {
        static int field1;
        static int field2;
        public static int Field1
        {
            get { return field1; }
        }
        public static int Field2
        {
            get { return field2; }
        }
        public static void UpdateFields()
        {
            for (int i = 0; i < 1000000; i++)
            {
                lock (typeof(StaticLockCounte)) //Implicit Monitor.Enter(this)
                {
                    field1++;
                    if (field1 % 2 == 0)
                    {
                        field2++;
                    } //Implicit Monitor.Exit(this)
                }
            }
        }
    }

    class DeadLockClass
    {
        public static void DeadLockMethod()
        {
            DeadLockClass dlc = new DeadLockClass();
            Monitor.Enter(dlc);
            dlc = null;
            GC.Collect(0);
            GC.WaitForPendingFinalizers();

            Console.WriteLine("never be write");
        }
        ~DeadLockClass()
        {
            lock (this)
            {
                Console.WriteLine("Write Log-File");
            }
        }
    }
}
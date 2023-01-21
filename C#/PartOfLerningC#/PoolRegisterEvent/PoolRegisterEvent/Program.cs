namespace PoolRegisterEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent are=new AutoResetEvent(false);

            RegisteredWaitHandle rwh = ThreadPool.RegisterWaitForSingleObject(are, EventOperation, null, 5000, false);

            char oparation;
            Console.WriteLine("S=Signal, Q=Quit?");
            do
            {
                oparation = Char.ToUpper(Console.ReadKey(true).KeyChar);
                if (oparation == 'S')
                    are.Set();
            } while (oparation != 'Q');
            rwh.Unregister(null);
        }
        private static void EventOperation(Object state , Boolean timeOut)
        {
            if (timeOut)
            {
                Console.WriteLine("Time of waiting in over");
            }
            else
            {
                Console.WriteLine("Thread {0} worked out", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
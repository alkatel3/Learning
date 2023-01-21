namespace UsingTimer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autoEvent =new AutoResetEvent(false);
            var statusChecker = new StatusChecker(10);

            Console.WriteLine("{0:h:mm:ss:fff} Creating timer.\n",DateTime.Now);

            var stateTimer = new Timer(statusChecker.CheckStatus, autoEvent, 1000, 250);
            autoEvent.WaitOne();
            stateTimer.Change(0, 500);
            Console.WriteLine("\nChanging period to 5 second.\n");
            autoEvent.WaitOne();
            stateTimer.Dispose();
            Console.WriteLine("\nDestroying timer.");


        }

        public static void TimerMethod(object a)
        {
            Console.WriteLine("Hello in timer");
        }
    }
    class StatusChecker
    {
        private int invokeCount;
        private int maxCount;

        public StatusChecker(int count)
        {
            invokeCount = 0;
            maxCount = count;
        }

        public void CheckStatus(object stateInfo)
        {
            AutoResetEvent autoEvent=(AutoResetEvent)stateInfo;
            Console.WriteLine("{0} checking status {1,2}.", DateTime.Now.ToString("h:mm:ss:fff"), (++invokeCount).ToString());
            if(invokeCount == maxCount)
            {
                invokeCount = 0;
                autoEvent.Set();
            }
        }
    }
}
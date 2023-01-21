namespace FibonacciCalculator
{
    public class FibonacciCalculatorClass
    {
        private ManualResetEvent ev;
        public int Number { get; private set; }
        public int Result { get; private set; }
        public FibonacciCalculatorClass(ManualResetEvent ev, int number)
        {
            this.ev = ev;
            Number = number;
        }
        public void CallbackMethod(object obj)
        {
            Console.WriteLine("Thread {0} started...",Thread.CurrentThread.ManagedThreadId);

            Result = CalcMethod(Number);
            Console.WriteLine("Thread {0} calculation finished",Thread.CurrentThread.ManagedThreadId);
            ev.Set();
        }
        public int CalcMethod(int number)
        {
            if(number <= 1)
            {
                return number;
            }
            return CalcMethod(number - 1)+CalcMethod(number-2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            const int threadCount = 10;

            ManualResetEvent[] finishEvents=new ManualResetEvent[threadCount];

            FibonacciCalculatorClass[] numberArr = new FibonacciCalculatorClass[threadCount];

            Random r=new Random();

            Console.WriteLine("Run operation of calculate");

            for(int i =0; i < threadCount; i++)
            {
                finishEvents[i] = new ManualResetEvent(false);

                FibonacciCalculatorClass f = new FibonacciCalculatorClass(finishEvents[i], r.Next(30, 50));

                numberArr[i] = f;
                ThreadPool.QueueUserWorkItem(f.CallbackMethod);
            }
            WaitHandle.WaitAll(finishEvents);
            Console.WriteLine("Calculate finshed");

            for(int i=0; i < threadCount; i++)
            {
                FibonacciCalculatorClass f = numberArr[i];
                Console.WriteLine("{0}-th number Fibonacci is {1}", f.Number, f.Result);
            }
        }
    }
}
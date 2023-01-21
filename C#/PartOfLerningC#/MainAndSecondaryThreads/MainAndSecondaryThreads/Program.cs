namespace MainAndSecondaryThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();
            Thread.Sleep(100);
        }
        static void Method()
        {
            for (int i = 0; i < 10; i++)
               Console.WriteLine(new String('\t', i) + "*");
            
        }
    }
}
namespace UsingStaticPropertiesClassThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            Thread thisThread = Thread.CurrentThread;
            Console.WriteLine(thisThread.GetHashCode());
        }
    }
}
namespace OneInstanceApp
{
    internal class Program
    {
        static Mutex m;
        static void Main(string[] args)
        {
            try
            {
                m = Mutex.OpenExisting("MY_MUTEX");
            }
            catch (WaitHandleCannotBeOpenedException e) { }

            if (m != null)
            {
                Console.WriteLine("App has already launch");
                Console.ReadKey();
                return;
            }
            
            using(m=new Mutex(true, "MY_MUTEX"))
            {
                Console.WriteLine("App is working.\nPush any button for close app");
                Console.ReadKey();
            }

           
        }
    }
}
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lesson_17
{
    class Program
    {
        static void Main(string[] args)

        {

            #region Thread
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();
            //Thread thread1 = new Thread(new ParameterizedThreadStart(DoWork1));
            //thread1.Start(int.MaxValue);
            //int j = 0;
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    j++;
            //    if (j % 10000 == 0)
            //        Console.WriteLine("Main");
            //}
            #endregion;
            #region
            //Console.WriteLine("Begin Main");
            //            DoWorkAsync();
            //            Console.WriteLine("Main continue");
            //            int j = 0;
            //            for (int i = 0; i < 10; i++)
            //            {
            //                j++;

            //                    Console.WriteLine("Main");
            //            }
            //            Console.WriteLine("End Main");
            #endregion
            var result = SaveFile("olya.txt");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static bool SaveFile(string path)
        {
            var rnd = new Random();
            var text = 0;
            for (int i=0;i<1000; i++)
            {
                text += rnd.Next();
            }
           
            using(var sw=new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
                
        return true;
        } 
       static async Task DoWorkAsync()
        {
            Console.WriteLine("begin async");
            await Task.Run(() => DoWork());
            Console.WriteLine("End Asinc");
        }
            static void DoWork()
        {
            int j = 0;
            for(int i=0; i<10; i++)
            {
                j++;
               
                    Console.WriteLine("DoWork");

            }
        }
        static void DoWork1(object max)
        {
           
            int j = 0;
            for (int i = 0; i < (int)max; i++)
            {
                j++;
                if (j % 10000 == 0)
                    Console.WriteLine("DoWork1");
            }
        }
    }
}

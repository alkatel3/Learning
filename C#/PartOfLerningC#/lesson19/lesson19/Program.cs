using System;
using System.ComponentModel.DataAnnotations;

namespace Delegate
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate void Message();
        static void Main(string[] args)
        {
            Message mes;
            mes = Hello;
            mes += How;
            mes += finish;
            mes();
            Console.ReadKey();
            #region
            //Operation OP = Add;
            //int result = OP(10, 3);
            //Console.WriteLine(result);

            //Operation OP2 =new Operation( Multiply);//рівноцінно
            //result = OP(10, 3);
            //Console.WriteLine(result);

            Console.WriteLine(DateTime.Now);
            Message mes1;
            if (DateTime.Now.Hour < 12)
            {
                mes1 = GoodMorning;
            }
            else
            {
                mes1 = GoodEvening;
            }
            mes1();
            Console.ReadKey();
            #endregion
            mes += mes1;
            mes();

        }
        private static void Hello()
        {
            Console.WriteLine("Hello");
        }
        private static void How()
        {
            Console.WriteLine("How are you");
        }
        private static void finish()
        {
            Console.WriteLine("finish");

        }

        #region
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        //private static int Multiply(int x,int y)
        //{
        //    return x * y;
        //}
        //private static int Add(int x,int y)
        //{
        //    return x + y;
        //}
        #endregion
    }
}

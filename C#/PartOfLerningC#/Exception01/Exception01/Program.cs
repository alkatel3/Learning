using System;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {

            byte a, b, result=0;
            a = b = 127;
           
            try
            {
                result = checked((byte)(a*b));
                Console.WriteLine(result+"}]]]]]]]");
            }

            catch(OverflowException ew)
            {
                //ew = new OverflowException("Перовнення");
                Console.WriteLine(ew);
            }
            

            //try
            //{
            //    RangeArray ran1 = new RangeArray(-5, 5);
            //    RangeArray ran2 = new RangeArray(1, 10);
            //    Console.WriteLine("ran1.Length " + ran1.Length);
            //    for(int i = -5; i <= 5; i++)
            //    {
            //        ran1[i] = i;
            //    }
            //    Console.WriteLine("ran1:");
            //    for(int i = -5; i <= 5; i++)
            //    {
            //        Console.Write(ran1[i] + "\t");
            //    }
            //    Console.WriteLine("\n");

            //    Console.WriteLine("ra2.Length: " + ran2.Length);
            //    for(int i = 1; i <= 10; i++)
            //    {
            //        ran2[i] = i;
            //    }

            //    Console.WriteLine("ran2:");
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.Write(ran2[i] + "\t");
            //    }
            //}
            //catch (RangeArrayException ex)
            //{
            //    Console.WriteLine("\n" + ex);
            //}

            //Console.WriteLine("\nСгенерировать ошибки нарушения границ.");
            //// Использовать неверно заданный конструктор.
            //try
            //{
                
            //    RangeArray ra3 = new RangeArray(100, -10); // Ошибка!
            //}
            //catch (RangeArrayException exc)
            //{
            //    Console.WriteLine(exc);
            //}
            //// Использовать неверно заданный индекс.
            //try
            //{
            //    RangeArray ra3 = new RangeArray(-2, 2);
            //    for (int i = -2; i <= 2; i++)
            //        ra3[i] = i;
            //    Console.Write("Содержимое массива ra3: ");
            //    for (int i = -2; i <= 10; i++) // сгенерировать ошибку нарушения границ
            //        Console.Write(ra3[i] + " ");
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc);
            //}
            
        }
    }
}

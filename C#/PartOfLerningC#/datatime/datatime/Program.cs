using System;


namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //var date1 = new DateTime();
            //Console.WriteLine(date1);
            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.MaxValue);
            //var date2 = new DateTime(2020, 4, 23, 1, 58, 55);
            //Console.WriteLine(date2);
            //var date3 = new DateTime(2020, 4, 23);
            //Console.WriteLine(date3);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Today);
            var MB = new DateTime(2002, 9, 8,22,24,55);
            //Console.WriteLine(MB.DayOfYear);
            //Console.WriteLine(DateTime.Now.AddYears(-40).DayOfWeek);
            //Console.WriteLine(MB.DayOfWeek);
            //Console.WriteLine(MB.AddYears(19));
            //Console.WriteLine(MB.AddHours(20));
            //Console.WriteLine(DateTime.Now.AddHours(3).Subtract(DateTime.Now)) ;
            //Console.WriteLine(MB.ToShortDateString());
            //Console.WriteLine(MB.ToLongDateString());
            Console.WriteLine("D: {0:D} " , MB);
            Console.WriteLine("d: {0:d}" ,MB);
            Console.WriteLine("F: {0:F}" ,MB);
            Console.WriteLine("f: {0:f}", MB);
            Console.WriteLine("G: {0:G}", MB);
            Console.WriteLine("g: {0:g}", MB);
            Console.WriteLine("M: {0:M}", MB);
            Console.WriteLine("O: {0:O}", MB);
            Console.WriteLine("o: {0:o}", MB);
            Console.WriteLine("R: {0:R}", MB);
            Console.WriteLine("s: {0:s}", MB);
            Console.WriteLine("T: {0:T}", MB);
            Console.WriteLine("t: {0:t}", MB);
            Console.WriteLine("U: {0:U}", MB);
            Console.WriteLine("u: {0:u}", MB);
            Console.WriteLine("Y: {0:Y}", MB);

        }
    }
}

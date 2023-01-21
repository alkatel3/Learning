using System;

namespace ConsoleApp38
{
    class bonus 
    {
        public static int bon=100;
        public int totalsum;
        public  bonus(int sum)
        {
            totalsum = sum + bon;
        } 
    }


    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(bonus.bon);
            bonus.bon += 50;
            bonus p1 = new bonus(300);
            Console.WriteLine(p1.totalsum);
            bonus p2 = new bonus(1000);
            Console.WriteLine(p2.totalsum);
            
        }
    }
}

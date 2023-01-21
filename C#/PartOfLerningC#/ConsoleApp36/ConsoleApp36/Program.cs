using System;

namespace ConsoleApp36
{
   class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.add(5, 6);
            cal.add(5, 6, 7);
            cal.add(5, 6, 7, 8);
            cal.add(5.5, 6.5);
        }
    }
    class Calculator
    {
        public void add(int a,int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void add(int a,int b,int c)
        {
            int result = a + b + c;
            Console.WriteLine(result);
        }
        public int add(int a, int b, int c, int d)
        {
            int result = a + b + c + d;
            Console.WriteLine(result);
            return result;
        }
        public void add(double a,double b)
        {
            double result = a + b;
            Console.WriteLine(result);
        }
        
            
       
    }
}

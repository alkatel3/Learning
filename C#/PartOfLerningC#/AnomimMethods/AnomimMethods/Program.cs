using System;
using static System.Console;

namespace AnonimMethods
{
    public delegate double AnonimDelegateDouble(double x, double y);
    public delegate int AnonimDelegateInt(int n);
    public delegate void AnonimDelegateVoid();

    class Dispacher
    {
        public event AnonimDelegateDouble eventDouble;
        public event AnonimDelegateInt eventInt;

        public double OnEventDouble(double x, double y)
        {
            if (eventDouble != null)
            {
                return eventDouble(x, y);
            }
            throw new NullReferenceException();
        }
        public int? OnEventInt(int n = 0)
        {
              return eventInt?.Invoke(n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\tThe use of events");
            Dispacher dispacher =new();

            dispacher.eventDouble +=  (double a, double b)=>
              {
                  if (b != 0)
                  {
                      return a / b;
                  }
                  throw new DivideByZeroException();
              };
            double n1 = 5.7, n2 = 3.2;

            WriteLine($"{n1} / {n2} = " +
                $"{dispacher.OnEventDouble(n1, n2)}");
            WriteLine("\tUsing a local variable");
            int number1 = 5, number2 = 6;


            dispacher.eventInt += n => number1 + n;
            
            WriteLine($"{number1} + {number2} = {dispacher.OnEventInt(number2)}");
            

            WriteLine("\tThe use of a delegate");

            AnonimDelegateVoid voidDel = new AnonimDelegateVoid(()=> { WriteLine("OK!"); });
            voidDel += delegate { WriteLine("Bye!"); };
            voidDel();
        }
    }
}

using System;

namespace ConsoleApp62
{
    
    class Program
    {
        
//public delegate void MyDelegate();
//        public delegate int MethodValue(int a);
//        public event MyDelegate Event;
//        public event Action EventAction;
      static void Main(string[] args)

        {
            Person person = new Person
            {
                Name = "Vasya"
            };
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            Person_GoToSleep();
            
            person.TakeTime(DateTime.Parse("09.03.2021 11:18:01"));
            person.TakeTime(DateTime.Parse("09.03.2021 19:18:01"));
            #region delegate;

            //MethodValue methodvalue = new MethodValue(methodValue);
            //methodvalue += methodValue;
            //    methodvalue += methodValue;
            //    methodvalue += methodValue;
            //    methodvalue += methodValue;
            //    methodvalue += methodValue;
            //    methodvalue += methodValue;
            //    methodvalue.Invoke(new Random().Next(1,5));
            //   MyDelegate mydelegate = Method1;
            //mydelegate += Method5;
            //    mydelegate();
            //MyDelegate mydelegate2 = new MyDelegate(Method5);
            //mydelegate2 += Method5;
            //    mydelegate2 -= Method5;
            //    mydelegate2();

            //MyDelegate mydelegate3 = mydelegate + mydelegate2;
            //mydelegate3();
            //mydelegate += mydelegate2;
            //    mydelegate();
            //    Action action = Method1;
            //    action();
            //    Action<int,int> action1 = Method4;
            //    action1(new Random().Next (0,50),new Random().Next(-50,0));
            //    Predicate<int> predicate = Method3;
            //    predicate(new Random().Next(-50, 50));
            //Console.ReadKey();
            #endregion;
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            if (sender is Person)
            {
                Console.WriteLine($"{((Person)sender).Name} is working");
                Console.ReadKey();
            }
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Person goto sleep");
            Console.ReadKey();
        }
        //static public void Method1()
        //{
        //    Console.WriteLine("Method1");
        //}
        //static public int Method2()
        //{
        //    Console.WriteLine("Method2");
        //    return 0;
        //}
        //static public bool Method3(int i)
        //{
        //    Console.WriteLine($"Method3 i={i} ");
        //        return true;
        //}
        //static public void Method4(int i, int j)
        //{
        //    Console.WriteLine("Method4");
        //}
        //static public void Method5()
        //{
        //    Console.WriteLine("Method5");
        //}
        //public static int methodValue(int i)
        //{
        //    Console.WriteLine(i);
        //    return i;
        //}

    }
}

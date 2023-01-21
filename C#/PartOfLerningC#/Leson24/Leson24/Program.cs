using System;
using System.Collections.Generic;
using System.Linq;

namespace Leson24
{
    class Program
    {
       public delegate int MyHandler(int i);
        static void Main(string[] args)
        {
            var lesson = new Lesson("Programe C#");
            lesson.Started += (sender, date) =>
            {
                Console.WriteLine(sender);
                Console.WriteLine(date);
            };
            lesson.Start();

            var list = new List<int>();
            for(int i=0;i<10;i++)
            {
             
                list.Add(i);
            }
           var res= list.Aggregate((x, y) => x + y);
            Console.WriteLine(res);

            var result1 = Arg(list, delegate (int i)
              {
                  int r = i * i;
                  Console.WriteLine(r);
                  return i * i;
              });
            var result2 = Arg(list, Method);
            var result3 = Arg(list, x => x * x * x * x);



            if (int.TryParse(Console.ReadLine(), out int result))
            {
                MyHandler handler = delegate (int i)
                  {
                      int r = i * i;
                      Console.WriteLine(r);
                      return i * i;
                  };
                handler += Method;
                handler(result);

            }
            Console.ReadLine();
        }
        public static int Method(int i)
        {
            int r = i * i*i;
            Console.WriteLine(r);
            return i * i * i;
        } 
        public static int Arg(List<int> list,MyHandler handler)
        {
            int result = 0;
            foreach(var item in list)
            {
                result += handler(item);
            }
            return result;
        }
    }
}

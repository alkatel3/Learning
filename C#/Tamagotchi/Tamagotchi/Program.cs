using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Reflection;
using System.Threading;

namespace Tamagotchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += MessageToUser.Sleep;
            timer.Elapsed += MessageToUser.Play;
            timer.Elapsed += MessageToUser.Walk;
            timer.Elapsed += MessageToUser.Feed;
            timer.Interval = 1000;
            timer.Start();
            
            //Type type= typeof(MessageToUser);
            //MethodInfo[] methods= type.GetMethods();
            //foreach(MethodInfo method in methods)
            //{
            //    if(method.GetParameters().Length == 2)
            //    {
            //        timer.Elapsed += method;
            //    }

            //}
        }
    }
}

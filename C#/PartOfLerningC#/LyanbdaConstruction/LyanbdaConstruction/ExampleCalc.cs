using System;
using static System.Console;

namespace LyanbdaConstruction
{
    class ExampleCalc
    {
        public string CurrentDate =>$"\tThe current date {DateTime.Now.ToLongDateString()}\n";
        public int AddInt(int x, int y) => x + y;
        public static void AddVoid(int x, int y) =>
            WriteLine($"{x} + {y} = {x + y}");
    }
}

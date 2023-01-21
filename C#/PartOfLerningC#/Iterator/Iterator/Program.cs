using System;
using static System.Console;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditory students = new Auditory();

            WriteLine("-------List of students--------");

            foreach(var student in students)
            {
                WriteLine(student);
            }
        }
    }
}

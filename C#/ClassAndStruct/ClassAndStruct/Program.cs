using System;
using System.Text;

namespace Learning
{
    class Program
    {
        static void Main()
        {
            Student st = new Student("a", "v", "s", "s", 12);
            st.GetMark(Discipline.Administration, 12);
            st.GetInformation();
            Console.WriteLine(st.GetAverageMark(Discipline.Administration));

            Console.WriteLine(st.GetAverageMark(Discipline.Design));
            Console.WriteLine(st.GetAverageMark(Discipline.Programming));
        }
    }
}

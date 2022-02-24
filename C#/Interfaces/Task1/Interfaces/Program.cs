using System;
using static System.Console;
using System.Collections;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            WriteLine("++++++++++++++++++++список студентов++++++++++\n");
            foreach (Student student in auditory)
            {
                WriteLine(student);
            }
            WriteLine("\n++++++++++++++ + сортировка по фамилии++++++++\n");
            auditory.Sort();
            foreach (Student student in auditory)
            {
                WriteLine(student);
            }
            WriteLine("\n++++++++++++ сортировка по дате рождения++++ +\n");
            auditory.Sort(new DateComparer());
            foreach (Student student in auditory)
            {
                WriteLine(student);
            }
            WriteLine("\n++++++++++++++++++++ + копирование ++++++++++++\n");
            Student student1 = new Student
            {
                FirstName = "Greg",
                LastName = "Carter",
                BirthDate = new DateTime(1999, 12, 5),
                studentCard = new StudentCard
            {
                Number = 784523,
                Series = "ММ" }
            };
            Student student2 = (Student)student1.Clone();
            WriteLine(student1);
            WriteLine(student2);
            WriteLine("\n++++++++++++++++++++++ изменение ++++++++++++ +\n");
            student2.studentCard.Number = 817423;
            student2.studentCard.Series = "КК";
            WriteLine(student1);
            WriteLine(student2);
        }
    }
}

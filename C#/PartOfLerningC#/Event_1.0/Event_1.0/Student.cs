using System;
using static System.Console;

namespace Event_1._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public void Exam(object sender, ExamEventArgs e)
        {
            WriteLine($"Student {LastName} solved the {e.Task}");
        }
    }
}

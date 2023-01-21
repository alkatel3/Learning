using System;
using System.Collections.Generic;

namespace Event_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new()
            {
                new("John", "Miller", new DateTime(1997, 3, 12)),
                new("Candice", "Leman", new DateTime(1998, 7, 22)),
                new("Joey", "Finch", new DateTime(1996, 11, 30)),
                new("Nicole", "Taylor", new(1996, 5, 10))
            };
            Teacher teacher = new();
            foreach(var item in group)
            {
                teacher.examEvent += item.Exam;
            }
            Student student = new("John", "Doe", new DateTime(1998, 10, 12));
            teacher.examEvent += student.Exam;
            ExamEventArgs eventArgs = new() { Task = "Task #1" };
            teacher.Exam(eventArgs);
            Console.WriteLine();
            teacher.examEvent -= student.Exam;
            eventArgs.Task = "Task #2";
            teacher.Exam(eventArgs);
        }

    }
}

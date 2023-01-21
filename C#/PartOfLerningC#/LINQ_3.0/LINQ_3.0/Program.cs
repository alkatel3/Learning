using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LINQ_3._0
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

        public override string ToString()
        {
            return $"Surname: {LastName}," +
                $" Name: {FirstName}," +
                $" Born: { BirthDate.ToLongDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const double daysOfYear = 365.25;

            List<Student> students = new()
            {
                new Student("John", "Miller", new DateTime(1997, 3, 12)),
                new Student("Candice", "Leman", new DateTime(1998, 7, 22)),
                new Student("Nicole", "Taylor", new DateTime(1996, 1, 10)),
                new Student("Joey", "Finch", new DateTime(1996, 1, 10))
            };
            WriteLine($"\tThe current date: {DateTime.Now.ToLongDateString()}");

            var query = students.Where(s=> (DateTime.Now - s.BirthDate).Days / daysOfYear > 20).Select(s=>s);
            WriteLine("Students older than 20 years:");
            foreach(var item in query)
            {
                WriteLine(item);
            }
            Console.WriteLine();

            var student = from s in students
                          where s.BirthDate == (from b in students select b.BirthDate).Max()
                          select s;

            foreach(var item in student)
            {
                WriteLine(item);
            }

            var minAge = (from s in students select s).Min(s => (DateTime.Now - s.BirthDate).Days / daysOfYear);
            WriteLine($"Age: {(int)minAge}");
        }
    }
}

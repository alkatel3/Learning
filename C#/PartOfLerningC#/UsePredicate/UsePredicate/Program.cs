using System;
using System.Collections.Generic;
using static System.Console;
namespace SimpleProject
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString()
        {
            return $"Surname: {LastName}, Name: { FirstName}, Born: { BirthDate.ToLongDateString()}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> group = new List<Student>
            {
                new Student {
 FirstName = "John",
 LastName = "Miller",
 BirthDate = new DateTime(1997,3,12)
 },
 new Student {
 FirstName = "Candice",
 LastName = "Leman",
 BirthDate = new DateTime(1998,7,22)
 },
 new Student {
 FirstName = "Joey",
 LastName = "Finch",
 BirthDate = new DateTime(1996,11,30)
 },
 new Student {
 FirstName = "Nicole",
 LastName = "Taylor",
 BirthDate = new DateTime(1996,5,10)
 }
 };
            WriteLine("Born in the spring:");
            List<Student> students = group.FindAll(s =>
            s.BirthDate.Month >=
            3 && s.BirthDate.Month <= 5);
            foreach (Student item in students)
            {
                WriteLine(item);
            }
        }
    }
}


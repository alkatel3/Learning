using System;
namespace Iterator
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
            return $"Last name: {LastName}," +
                $" First name: {FirstName}," +
                $" Birth date: {BirthDate.ToLongDateString()}";
        }
    }
}

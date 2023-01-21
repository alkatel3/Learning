using MyLibrary;
using static System.Console;

Student student = new Student
{
    FirstName = "John",
    LastName = "Miller",
    DateOfBirth = new DateTime(1997, 3, 12)
};
Write(student);

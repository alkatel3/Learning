using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Vitaliy";
            person1.Age = 18;
            Person person2 = new Person();
            person2.Name = "OLya";
            person2.Age = 18;
            Doctor doctor = new Doctor();
            doctor.Name = "Pavlo";
            doctor.Age = 38;
            doctor.specialisation = "hirurg";
        }
    }
}

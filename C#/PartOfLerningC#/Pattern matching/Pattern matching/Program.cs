using System;

namespace Pattern_matching
{
    class Program
    {
        static void Main(string[] args)
        {
          var emp = new Manager();
            
            UserEmployee(emp);
            emp.IsOnVacation = true;
            UserEmployee(emp);
            Console.ReadKey();
        }
        static void UserEmployee(Employee emp)
        {
            if (emp is Manager maneger && maneger.IsOnVacation == false)
                maneger.Work();
            else
                Console.WriteLine("exeption");
        }
        
    }
    class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Да работаю я, работаю");
        }
    }

    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Отлично, работаем дальше");
        }
        public bool IsOnVacation { get; set; }
    }
}

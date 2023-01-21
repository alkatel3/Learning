using System;
using System.Reflection;

namespace UsingAttribute
{
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class)]
    public class CoderAttribute: Attribute
    {
        string _name = "Yuriy";
        DateTime _date = DateTime.Now;
        public CoderAttribute() { }

        public CoderAttribute(string name,string date)
        {
            try
            {
                _name = name;
                _date = Convert.ToDateTime(date);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return $"Coder: {_name}, Date: {_date}";
        }
    }
    [Coder]
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        [Coder("John","2017-3-29")]
        public void IncreaseWages(double wage)
        {
            Salary += wage;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tAttributes of class Employee:");

            foreach (var attr in typeof(Employee).GetCustomAttributes(true)) 
            {
                Console.WriteLine(attr);
            }
            Console.WriteLine("\n\tAttributes of members of class Emloyee:");
            foreach(MemberInfo info in typeof(Employee).GetMembers())
            {
                foreach(var attr in info.GetCustomAttributes(true))
                {
                    Console.WriteLine(attr);
                }
            }
        }
    }
}

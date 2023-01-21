namespace SimpleLibrary
{
    public enum PersonMaritalStatus
    {
        Married,
        Single
    }
    [Serializable]
    public class Person
    {
        string Name;
        string LastName;
        int Age;
        PersonMaritalStatus MaritsalStatus;

        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            MaritsalStatus= PersonMaritalStatus.Single;
        }
        public void Print()
        {
            Console.WriteLine("Person:\nName: " + Name + "\nLastname: " + LastName + "\nAge: " + Age);
        }
    }
    public class Employee : Person
    {
        string Position;
        decimal Salary;

        public Employee(string name, string lastName, int age,string position, decimal salary):base(name,lastName,age)
        {
            Position = position;
            Salary = salary;
        }
    }
}
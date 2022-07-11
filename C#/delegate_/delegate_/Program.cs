using System;

namespace delegate_
{
    class Student
    {
        string Name;
        string SecondName;

        public Student(string name, string secondName)
        {
            Name = name;
            SecondName = secondName;
        }
        public override string ToString()
        {
            return $"Name: {Name}\t Second Name: {SecondName}";
        }
    }
    class Program
    {
        static object FindObj(object[] objs, Predicate<object> del)
        {
            object res=null;
            foreach (var item in objs)
            {
                if (del(item))
                    res = item;
            }
            return res;
        }
        static bool IsStudent(object obj)
        {
            var type = obj.GetType();
            if (type.Name == "Student")
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            object[] objs = 
            {
                new Student("Oleg","Yovyk"),
                14,
                "Hello",
                13.123,
            };
            Console.WriteLine(FindObj(objs, IsStudent));
        }
    }
}

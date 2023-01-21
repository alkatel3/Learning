using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LINQ
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
    }
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };
            string[] poem =
            {
                "All the world's a stage," ,
                "And all the men and women merely players; " ,
                "They have their exits and their entrances," ,
                "And one man in his time plays many parts," ,
                "His acts being seven ages…"
            };

            List<Group> groups = new()
            {
                new Group
                {
                    Id = 1,
                    Name = "27PPS11"
                },
                new Group
                {
                    Id = 2,
                    Name = "27PPS12"
                }
            };
            List<Student> students = new()
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Miller",
                    GroupId = 2
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Joey",
                    LastName = "Finch",
                    GroupId = 1
                },
                new Student
                {
                    FirstName = "Nicole",
                    LastName = "Taylor",
                    GroupId = 2
                }
            };

            var query1 = from i in arrayInt
                        group i by i % 10 into res
                        where res.Count() > 1
                        select res;

            var query2 = from p in poem
                         let words = p.Split(' ', ';', ',')
                         from w in words
                         where w.Count() > 5
                         select w;

            var query3 = from g in groups
                         join st in students on g.Id equals
                         st.GroupId into res
                         from r in res
                         select r;

            foreach(var key in query1)
            {
                Write($"Key: {key.Key}\nValue ");
                foreach(int item in key)
                {
                    Write($" {item}");
                }
                WriteLine();
            }
            WriteLine("\nWords, in which more than 5 characters");
            foreach(var word in query2)
            {
                WriteLine(word);
            }
            WriteLine();
            WriteLine("Student in groups");
            foreach(var item in query3)
            {
                WriteLine($"Surname: {item.LastName}, Name: {item.FirstName}, Group: {groups.First(g => g.Id == item.GroupId).Name}");
            }
        }
    }
}

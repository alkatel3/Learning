using System;
using System.Collections;
using static System.Console;

namespace UserTypeInArrayList
{
    class Program
    {
        static Hashtable  group = new Hashtable()
        {
                {
                new Student("John", "Miller", new DateTime(1997, 3, 12)),
                new ArrayList{8,4,9}
                },
                {
                    new Student("Candice", "Leman", new DateTime(1998, 7, 22)),
                    new ArrayList{12,9,10}
                }
        };

        static void SetRating(string name,int mark)
        {
            WriteLine($"-------Student: {name} get mark: {mark}-------");
            foreach(Student item in group.Keys)
            {
                if (item.LastName == name)
                {
                    (group[item] as ArrayList).Add(mark);
                }
            }
        }
        static void RatingsList()
        {
            WriteLine("---------List studetns with marks--------");
            foreach(Student student in group.Keys)
            {
                Write($"{student}: ");
                foreach (int item in group[student] as ArrayList)
                {
                    Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ArrayList auditory = new()
            {
                new Student("John", "Miller", new DateTime(1997, 3, 12)),
                new Student("Candice", "Leman", new DateTime(1998, 7, 22)),
            };

            WriteLine("----List of students----");
            foreach (var item in auditory)
                WriteLine(item);

            WriteLine("----Sorting by sername----");
            auditory.Sort();
            foreach(var item in auditory)
            {
                WriteLine(item);
            }
            WriteLine("----Sorting by date of birth");
            auditory.Sort(new DateComparer());
            foreach(var item in auditory)
            {
                WriteLine(item);
            }



            RatingsList();
            SetRating("Leman", 11);
            RatingsList();

        }
    }
}

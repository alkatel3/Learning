using System;
using System.Collections;

namespace Interfaces
{
    class Auditory : IEnumerable
    {
        Student[] students =
        {
            new Student
            {
                FirstName ="John",
                LastName ="Miller",
                BirthDate =new DateTime(1997,3,12),
                studentCard =new StudentCard { Number=189356,
                Series="AB" }
            },
            new Student
            {
                FirstName ="Candice",
                LastName ="Leman",
                BirthDate =new DateTime(1998,7,22),
                studentCard = new StudentCard
                {
                              Number=345185,
                              Series="XA"
                }
            },
            new Student
            {
                FirstName ="Joey",
                LastName ="Finch",
                BirthDate = new DateTime(1996,11,30),
                studentCard = new StudentCard { Number=258322,
                Series="AA" }
            },
            new Student {
                FirstName ="Nicole",
                LastName ="Taylor",
                BirthDate = new DateTime(1996,5,10),
                studentCard = new StudentCard { Number=513484,
                Series="AA" }
            }
        };

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }

        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
    }
}

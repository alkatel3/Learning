using System;

namespace Interfaces
{
    class Student:IComparable,ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard studentCard { get; set; }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.studentCard = new StudentCard
            {
                Series = this.studentCard.Series,
                Number = this.studentCard.Number
            };
            return temp;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\t{BirthDate:D}\t{studentCard}";
        }
    }
}

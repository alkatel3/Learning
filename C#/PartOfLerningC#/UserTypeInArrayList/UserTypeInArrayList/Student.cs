using System;

namespace UserTypeInArrayList
{
    class Student: IComparable
    {
        public Student(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
  
        public override string ToString()
        {
            return $"Sername: {LastName}\t" +
                $"First Name: {FirstName}\t" +
                $"Date of birth: {BirthDate}";
        }
        public int CompareTo(object obj)
        {
            if(obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);
            }
            throw new NotImplementedException();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}

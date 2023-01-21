using System;


namespace рядки
{
    public class Person
    {
        string Name { get; }
      public  Person( string name)
        {
            Name = name;
        }
        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name;
        }
        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Name != p2.Name;
        }
    }
}

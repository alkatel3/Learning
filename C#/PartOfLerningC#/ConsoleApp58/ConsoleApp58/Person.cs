using System;


namespace ConsoleApp58
{
    class Person
    {
        
        public string SecondName { get; private set; } 

        public string Name { get; private set; }
        public Person(string name,string secondname)
        {
            Name = name;
            SecondName = secondname;
        }
       public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }
    }
}

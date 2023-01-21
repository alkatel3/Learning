using System;


namespace destracte
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Deconstruct( out string name,out int age)
        {
            name = this.Name;
            age = this.Age;
        }
    }
}

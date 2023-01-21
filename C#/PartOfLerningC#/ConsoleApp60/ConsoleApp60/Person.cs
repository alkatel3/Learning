using System;


namespace ConsoleApp60
{
    class Person
    {
        private string Sername { get;set; }
        private string Name { get; set; }
        private int X { get; set; }
        private int Y { get; set; }
        public Person(string name,string sername)
        {
            Sername = sername;
            Name = name;
            X = 0;
            Y = 0;

        }
        public string FoolName
        {
            get
            {
                return Sername +" "+ Name;
            }
        }
        public string run()
        {
            var random = new Random();
            X += random.Next(-2, 2);
            Y += random.Next(-2, 2);
            return $"{Name}: ({X},{Y})";
        }
    }
}

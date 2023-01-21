using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var pupils = new Dictionary<int, string>();
            pupils.Add(1, "Oleg");
            pupils.Add(2, "Stepan");
            pupils.Add(3, "Semen");
            foreach(var item in pupils)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
            pupils.Remove(2);
            foreach (var item in pupils)
            {
                Console.WriteLine("\t"+item.Key + "-" + item.Value);
            }
            var people = new Dictionary<string, Person>
            {
            { "England", new Person(){Name="Oleg"}},
                {"Germa" , new Person(){Name="Olena"}}
            };
            foreach (var item in people)
            {
                Console.WriteLine( item.Key + "-" + item.Value.Name);
            }
            var country = new Dictionary<string, string>
            {
                ["1"] = "Ukraine",
                ["2"] = "USA",
                ["3"] = "England"
            };
            foreach (var item in country)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
        class Person
        {
            public string Name { get; set; }
        }
    }
}

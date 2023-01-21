using System;

namespace anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new User() { Name = "Tom" };
            var ex1 = new { Name = "Tom", Age = 18 };
            var ex2 = new { Name = "Oleg", Age = 17 };
            var ex3 = new { Name = "Olya", Age = 18, University = "Franka" };
            var ex4 = new { tom.Name, Age = 80 };//ініціалізація через проекцію
            var people = new[] { ex1, ex2,ex4 };
            Console.WriteLine(ex1.Name);
            Console.WriteLine(ex1.Age);
            //ex1.Name = "Oleg"; Так не можна 

            Console.WriteLine(ex1.GetType());
            Console.WriteLine(ex2.GetType());
            Console.WriteLine(ex3.GetType());
            Console.WriteLine(ex4.GetType());
            Console.WriteLine(ex1.Name.GetType());
            Console.WriteLine(ex4.Name);
            Console.WriteLine(ex4.Age);
            foreach(var i in people)
            {
                Console.WriteLine(i.);
            }
        }
        public class User
        {
            public string Name { get; set; }

        }
    }
}

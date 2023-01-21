using System;


namespace patern_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //int x = Select(1, 5, 10);
            //Console.WriteLine(x);
            //Console.ReadLine();
            //int y = Select(10, 10, 10);

            //Console.WriteLine(y);
            #endregion
            #region 2
            //var person1 = new Person() { Name = "Oleg", Language = "english", Status = "student" };
            //var person2 = new Person() { Name = "Oleg", Language = "german", Status = "student" };
            //var person3 = new Person() { Name = "Taras", Language = "french", Status = "Admin" };
            //var person4 = new Person() { Name = "Stepan", Language = "german", Status = "Admin" };

            //Console.WriteLine(Massage(person1));
            //Console.WriteLine(Massage(person2));
            //Console.WriteLine(Massage(person3));
            //Console.WriteLine(Massage(person4));
            #endregion

            Console.WriteLine(Calculate(200));
            Console.WriteLine(Calculate(1000));
            Console.WriteLine(Calculate(5000));
            Console.WriteLine(Calculate(50));
            Console.WriteLine(Calculate(-10));
            Console.WriteLine(Calculate(5000));
            Console.WriteLine(Calculate(5));
            Console.WriteLine(Calculate(10000000));
            Console.WriteLine(Calculate(15043244));
            Console.WriteLine(Calculate(10000));

        }
        #region 1
        //static int Select(int op, int a, int b)=>op switch


        //    {
        //        1 => a + b,
        //        2 => a - b,
        //        3 => a * b,
        //        _ => throw new ArgumentException("fuck")
        //    };
        #endregion
        #region 2
        //static string Massage(Person person) => person switch
        //{
        //    { Language: "english" } => "Hello",
        //    { Language: "german", Status: "Admin" } => "Hallo Admin",
        //    { Language: "french" } => "Salut",
        //    { Language: "german", Name: var name } => $"Hallo {name}",
        //    { } => "undefined"

        //};
        #endregion
        static decimal Calculate(decimal number) => number switch
        {
            <= 0 => 0,
            < 5000 => number * 2,
            > 5000 and <= 10000 => number * 0.5m,
            5000 or > 10000 and < 15000 => number * 0.2m,
            _ => 1000000000000000
        };





    }
}

using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
           /* var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());
            foreach(ICar car in cars)
            {
                Console.WriteLine(car.Move(200));
            }*/
            Kiborg kiborg = new Kiborg();
            Console.WriteLine(((ICar)kiborg).Move(200));
            Console.WriteLine(((IPerson)kiborg).Move(200));

        }
    }
}

using System;
using System.Collections.Generic;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (; ; )
            {
                Console.Write("Input number:");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    //var isEven = IsEven(result);
                   
                    if (result.IsEven())
                    {

                        Console.WriteLine($"{result} - парне");
                    }
                    else
                    {
                        Console.WriteLine($"{result} - непарне");
                    }
                    break; 
                }
                else
                {
                    Console.WriteLine("Number mast be int");
                    continue;
                }
                
            }
            var v = 153;
               Console.WriteLine( v.IsDividedBe(3));
            var roads = new List<Road>();
            for (var i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);
                roads.Add(road);
            }
            var roadsName = roads.ConvertToString();
            Console.WriteLine(roadsName);
            Console.ReadLine();
        }
        //static bool IsEven (int x)
        //{
        //    return x % 2 == 0;
        //}
        

    }
}

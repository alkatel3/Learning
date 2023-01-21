using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var products = new List<Product>();
                for (int i = 0; i < 10; i++)
            {
                var product = new Product()
                {
                    Name = "product" + i,
                    Energy = rnd.Next(10, 20)
                };
                products.Add(product);
            }
            var result = from item in products
                         where item.Energy < 200
                         select (item);
            var result2 = products.Where(item => item.Energy < 200);
            foreach(Product item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (Product item in result2)
            {
                Console.WriteLine(item);
            }
            
            var selectCollection = products.Select(product => product.Energy);
            foreach (var item in selectCollection)
            {
                Console.WriteLine(item);
            }
            var OrderbyCollection = products.OrderBy(product=>product.Energy)
                                            .ThenByDescending(product=>product.Name);
            Console.WriteLine();
            foreach (var item in OrderbyCollection)
            {
                Console.WriteLine(item);
            }
            var groupbyCollection = products.GroupBy(product => product.Energy);
            foreach(var group in groupbyCollection)
            {
                Console.WriteLine($"Ключ:{group.Key}");
                foreach(var item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.WriteLine();
            }
            products.Reverse();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }












            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Generator
    {
        Random rnd = new Random();
        public List<Customer> customers { get; set; }=new List<Customer>();
        public List<Product> products { get; set; } = new List<Product>();
        public List<Seller> sellers { get; set; } = new List<Seller>();

        public List<Customer> GetNewCustomers(int count)
        {
            var result = new List<Customer>();
            for(int i = 0; i < count; i++)
            {
                var customer = new Customer()
                {
                    Name = GetRandomText(),
                    CustomerId = customers.Count
                };
                customers.Add(customer);
                result.Add(customer);
            }
            return result;
        }
        public List<Seller> GetNewSellers(int count)
        {
            var result = new List<Seller>();
            for (int i = 0; i < count; i++)
            {
                var seller = new Seller()
                {
                    Name = GetRandomText(),
                    SellerId = sellers.Count
                };
                sellers.Add(seller);
                result.Add(seller);
            }
            return result;
        }

        public List<Product> GetNewProducts(int count)
        {
            var result = new List<Product>();
            for (int i = 0; i < count; i++)
            {
                var product = new Product()
                {
                    Name = GetRandomText(),
                    ProductId = sellers.Count,
                    Count=rnd.Next(10,1000),
                    Price=Convert.ToDecimal(rnd.Next(5,100000)+rnd.NextDouble())
                };
                products.Add(product);
                result.Add(product);
            }
            return result;
        }

        public List<Product> GetRandomProducts(int min, int max)
        {
            var result = new List<Product>();
            var count = rnd.Next(min, max);

            for(int i =0; i < count; i++)
            {
                result.Add(products[rnd.Next(products.Count - 1)]);
            }
            return result;
        }

        private static string GetRandomText()
        {
            return Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}

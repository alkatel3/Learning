using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            //arrange
            Customer customer = new Customer()
            {
                Name = "testUser"
            };
            var product1 = new Product()
            {
                Name = "pr1",
                Price = 100,
                Count = 50
            };
            var product2 = new Product()
            {
                Name = "pr2",
                Price = 50,
                Count = 100
            };
            var cart = new Cart(customer);
            var expectedResult = new List<Product>()
            {
                product1, product1,product2
            };
            //act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartResult=cart.GetAll();
            //assert
            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for(int i=0;i<expectedResult.Count;i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }
        }
    }
}
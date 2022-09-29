using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //Arrange
            var customer1 = new Customer()
            {
                Name = "testUser1",
                CustomerId = 1
            };
            var customer2 = new Customer()
            {
                Name = "testUser2",
                CustomerId = 2
            };
            var Seller = new Seller()
            {
                Name="sellername",
                SellerId = 1
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 50
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 50,
                Count = 100
            };
            var cart1 = new Cart(customer1);
            var cart2 = new Cart(customer2);

            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);
            var cashDesk = new CashDesk(1, Seller,null );
            cashDesk.MaxQueueLenght = 10;
            cashDesk.Enqueue(cart1);
            cashDesk.Enqueue(cart2);
            var Cart1Result = 250;
            var Cart2Result = 200;
            //Act
            var cart1ActualResult = cashDesk.Dequeue();
            var cart2ActualResult = cashDesk.Dequeue();
            //Assert
            Assert.AreEqual(Cart1Result, cart1ActualResult);
            Assert.AreEqual(Cart2Result, cart2ActualResult);
            Assert.AreEqual(47, product1.Count);
            Assert.AreEqual(97, product2.Count);
        }
    }
}
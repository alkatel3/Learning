
using System;
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class CashDesk
    {
        CrmContext db;

        public int Number { get; set; }
        public Seller Seller { get; set; }
        public Queue<Cart> Queue { get; set; }
        public int MaxQueueLenght { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }
        public int Count => Queue.Count;

        public event EventHandler<Check> CheckClosed;

        public CashDesk(int number, Seller seller,CrmContext db)
        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
            MaxQueueLenght = 10;
            this.db=db??new CrmContext();
        }
        public void Enqueue(Cart cart)
        {
            if (Queue.Count < MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal Sum=0;
            if(Queue.Count == 0)
            {
                return 0;
            }
            var card = Queue.Dequeue();
            if (card != null)
            {
                var check = new Check()
                {
                    SellerId = Seller.SellerId,
                    Seller = Seller,
                    CustomerId = card.Customer.CustomerId,
                    Customer = card.Customer,
                    Created = System.DateTime.Now
                };
                if (!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckId = 0;
                }
                var sells = new List<Sell>();

                foreach(Product product in card)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckId = check.CheckId,
                            Check = check,
                            ProductId = product.ProductId,
                            Product = product
                        };

                        sells.Add(sell);
                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }

                        product.Count--;
                        Sum += product.Price;
                    }
                }
                check.Price = Sum;
                if (!IsModel)
                {
                    db.SaveChanges();
                }
                CheckClosed?.Invoke(this, check);
            }
            return Sum;
        }
        public override string ToString()
        {
            return $"Cashdesk №{Number}";
        }
    }
}

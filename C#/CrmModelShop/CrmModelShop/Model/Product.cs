using System.Collections;
using System.Collections.Generic;

namespace CrmBl.Model
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                return ProductId.Equals((obj as Product).ProductId);
            }
            return false;
        }       
        public override int GetHashCode()
        {
            return ProductId;
        }
    }
}
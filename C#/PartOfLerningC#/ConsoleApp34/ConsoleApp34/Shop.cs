using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Shop
    {
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int Square { get; set; }
        public int QuantityOfGoods { get; set; }
        public Shop(string name, string specialization, int square, int quantityofgoods)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (string.IsNullOrWhiteSpace(specialization))
            {
                throw new ArgumentNullException(nameof(specialization));
            }
            if (square <= 0)
            {
                throw new ArgumentNullException(nameof(square));
            }
            if (quantityofgoods < 0)
            {
                throw new ArgumentNullException(nameof(quantityofgoods));
            }
            Name = name;
            Specialization = specialization;
            Square = square;
            QuantityOfGoods = quantityofgoods;
        }
    }
}

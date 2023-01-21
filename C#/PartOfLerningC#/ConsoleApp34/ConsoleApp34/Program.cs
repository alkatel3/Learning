using System;
using System.Collections.Generic;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseholdGoods InKomarno = new HouseholdGoods("In Natal", "household goods", 30, 800);
            HouseholdGoods Peremozne = new HouseholdGoods("In Peremozne", "household goods", 50, 1000);

            Console.WriteLine("Input name shop in Pidzverynec");
            string NameInPidzvirynec = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input specialization shop in Pidzverynec");
            string SpecializationInPidzverynec = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Input square shop in Pidzverynec");
            int SquareInPidzverynec = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Input quatity Goods shop in Pidzverynec");
            int QuantityGoodsInPidzverynec = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            HouseholdGoods InPidzverynec = new HouseholdGoods("In Pidzverynec","household goods",10,100);
            Console.WriteLine(InPidzverynec.InformainformationAbouStop(InPidzverynec));
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Do shop \"In Peremozne\" equals shop \"In Pidzverynec\"?\n{Peremozne == InPidzverynec} ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Do shop \"In Komarno\" don't equals shop \"In Pidzverynec\"?\n{InKomarno != InPidzverynec} ");
            Console.ReadLine();
            Console.Clear();
            var rnd = new Random();
            var AddedGoods = rnd.Next(0, 100); 
            InKomarno.AddindGoogs( AddedGoods);
            Console.WriteLine(InKomarno.QuantityOfGoods);
             AddedGoods = rnd.Next(0, 100);
            InKomarno += AddedGoods;
            Console.WriteLine(InKomarno.QuantityOfGoods);
            var shop1 = InKomarno + Peremozne;
            Console.WriteLine(shop1.QuantityOfGoods);
        }
    }
}

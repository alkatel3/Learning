using System;


namespace ConsoleApp34
{
    class HouseholdGoods : Shop
    {
        public HouseholdGoods(string name, string specialization, int square, int quantityofgoods) : base(name, specialization, square, quantityofgoods)
        {

        }
        public static bool operator >(HouseholdGoods shop1, HouseholdGoods shop2)
        {
            return shop1.QuantityOfGoods > shop2.QuantityOfGoods;
        }
        public static bool operator <(HouseholdGoods shop1, HouseholdGoods shop2)
        {
            return shop1.QuantityOfGoods > shop2.QuantityOfGoods;
        }
        public static bool operator ==(HouseholdGoods shop1, HouseholdGoods shop2)
        {
            return shop1.Specialization == shop2.Specialization;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public static bool operator !=(HouseholdGoods shop1, HouseholdGoods shop2)
        {
            return shop1.Specialization != shop2.Specialization;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static HouseholdGoods operator +(HouseholdGoods shop1, int Addedgoods)
        {
            return new HouseholdGoods(shop1.Name, shop1.Specialization, shop1.Square, shop1.QuantityOfGoods + Addedgoods);
        }
        public static HouseholdGoods operator +(HouseholdGoods shop1, HouseholdGoods shop2)
        {
            if (shop1 > shop2)
            {
                return new HouseholdGoods(shop1.Name, shop1.Specialization, shop1.Square, shop1.QuantityOfGoods + shop2.QuantityOfGoods);
            }
            else
            {
                return new HouseholdGoods(shop2.Name, shop2.Specialization, shop2.Square, shop1.QuantityOfGoods + shop2.QuantityOfGoods);
            }

        }

        public string InformainformationAbouStop(HouseholdGoods Shop)
        {
            return $"{Shop.Name} is shop of {Shop.Specialization} with square {Shop.Square} and have {Shop.QuantityOfGoods} goods.";
        }
        public void AddindGoogs( int AddedGoods)
        {
            QuantityOfGoods += AddedGoods;
        }
    }
}

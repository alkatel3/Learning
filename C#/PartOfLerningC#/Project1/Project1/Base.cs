using System;

namespace Project1
{
    class Base
    {
        public virtual void Who()
        {
            Console.WriteLine("Метод Who() в класi Base");
        }
    }
    class Derived1 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Метод Who() в класi Derived1");
        }
    }
    class Derived2 : Base
    {
        public override void Who()
        {
            Console.WriteLine("Метод Who() в класi Derived2");
        }
    }
}

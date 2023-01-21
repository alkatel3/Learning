using System;

namespace Example
{
    class MyClass:IEven
    {
        public bool IsEven(int x) 
        {
            
            IEven Class=this;
            return Class.IsOdd(x);
            
        }

        bool IEven.IsOdd(int x)
        {
            if ((x % 2) != 0)
            {
                return true;
            }
            return false;
        }
        //static public MyClass Factory()
        //{
        //    IEven Class = this
        //}
    }
}

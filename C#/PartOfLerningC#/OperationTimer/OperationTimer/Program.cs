using System;
using System.Collections;
using System.Collections.Generic;

namespace OperationTimer
{
    class Program
    {
        private static void ValueTypePerfTest()
        {
            const int COUNT = 10000000;

            using (new Operation_Timer("List"))
            {
                List<int> list = new(COUNT);
                for (int n = 0; n < COUNT; n++)
                {
                    list.Add(n);
                    int x = list[n];
                }
                list = null;
            }
            using (new Operation_Timer("ArrayList"))
            {
                ArrayList array = new();
                for (int n = 0; n < COUNT; n++)
                {
                    array.Add(n);
                    int x = (int)array[n];
                }
                array = null;
            }
        }
        static void Main(string[] args)
        {
            ValueTypePerfTest();
        }
        
    }
}

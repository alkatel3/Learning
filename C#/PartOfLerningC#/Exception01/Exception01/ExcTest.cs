using System;

namespace Exception01
{
    class ExcTest
    {
        public static void GetException()
        {
            int[] num = new int[4];
            Console.WriteLine("before exception");

            for(int i = 0; i < 10; i++)
            {
                num[i] = i;
                Console.WriteLine($"num[{i}]: {num[i]}");
            }
            Console.WriteLine("It won't writen");
        }
    }
}

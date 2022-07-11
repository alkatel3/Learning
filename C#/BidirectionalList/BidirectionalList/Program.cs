using System;
using static System.Console;

namespace BidirectionalList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> l = new();

            for(int i =0;i<10; i++)
            {
                l.AddLast(i);
            }
            WriteLine("List after insert 10 elements to end:");
            l.PrintForward();

            l.InsertAt(500, 5);
            WriteLine("List afret insert 500 at index 5:");
            l.PrintForward();

            int[] arr = { 20, 30, 40 };
            l.InsertRangeAt(arr, 2);
            WriteLine("List after adding a range {20, 30, 40} at index 2:");
            l.PrintForward();

            l.RemoveFirst();
            WriteLine("List after remove first element:");
            l.PrintForward();

            l.RemoveAt(8);
            WriteLine("Liser after remove element at index 8:");
            l.PrintForward();

            l.RemoveRangeAt(6, 3);
            WriteLine("List after remote 3 element at index 6:");
            l.PrintForward();

            foreach ( var item in l)
            {
                Write($"{item} ");
            }
        }
    }
}

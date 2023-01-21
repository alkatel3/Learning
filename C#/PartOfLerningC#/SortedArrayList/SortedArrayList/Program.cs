using System;
using static System.Console;

namespace SortedArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorted_Array_List sortedAL = new();

            WriteLine("-------------Initial values-----------");
            sortedAL.AddSorted(200);
            sortedAL.AddSorted(-7);
            sortedAL.AddSorted(0);
            sortedAL.AddSorted(-20);
            sortedAL.AddSorted(56);
            sortedAL.AddSorted(200);
            sortedAL.AddSorted(400);

            foreach (int i in sortedAL)
            {
                Write(i + " ");
            }
            WriteLine();

            WriteLine("-------------Modifyed values------------");
            sortedAL.ModifySorted(3, 5);
            sortedAL.ModifySorted(-1, 2);
            sortedAL.ModifySorted(2, 4);
            sortedAL.ModifySorted(7, 3);

            foreach(int i in sortedAL)
            {
                Write(i + "  ");
            }

        }
    }
}

﻿using System;

namespace Algorithms
{
    public class BubbleSort<T> : AlgorithmBase<T>
        where T : IComparable<T>
    {
        public override void Sort()
        {
            var count = Items.Count;
            for (int j = count; j > 0; j--)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                }
                count--;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class SelectionSort<T> : AlgorithmBase<T>
        where T : IComparable
    {
        public SelectionSort(IEnumerable<T> items) : base(items) { }

        public SelectionSort() { }

        protected override void MakeSort()
        {
            for(int i = 0; i< Items.Count - 1; i++)
            {
                int MinValueIndex=i;
                for(int j = i+1; j < Items.Count; j++)
                {
                    if (Compare(Items[MinValueIndex],Items[j]) == 1)
                    {
                        MinValueIndex = j;
                    }
                }
                if (i != MinValueIndex)
                    Swop(i, MinValueIndex);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class QuickSort<T> : AlgorithmBase<T>
        where T : IComparable
    {
        public QuickSort(IEnumerable<T> items) : base(items) { }

        public QuickSort() { }

        protected override void MakeSort()
        {
            //Sort(Items.Count);
            Sort(0, Items.Count - 1);
        }

        private void Sort(int left, int right)
        {
            if (left >= right){
                return;
            }

            var pivot = Sorting(left, right);

            Sort(left, pivot-1);
            Sort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            for(int i=left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }
            Swop(pointer, right);
            return pointer;
        }


        //private void Sort(int count, int position = 0)
        //{
        //    if (count < 2)
        //    {
        //        return;
        //    }
        //    if (count == 2)
        //    {
        //        if (Compare(Items[position], Items[position + count - 1]) == 1)
        //        {
        //            Swop(position, position + count - 1);
        //        }
        //        return;
        //    }

        //    var rnd = new Random();
        //    var pivot = rnd.Next(position, position + count - 1);
        //    var left = position;
        //    var right = position + count - 1;


        //    while (left != right)
        //    {
        //        bool swop = true;
        //        if (Compare(Items[left], Items[pivot]) != 1 && left != pivot)
        //        {
        //            left++;
        //            swop = false;
        //        }

        //        if (Compare(Items[right], Items[pivot]) != -1 && right != pivot)
        //        {
        //            right--;
        //            swop = false;
        //        }

        //        if (swop)
        //        {
        //            Swop(left, right);
        //            left = position;
        //            right = position + count - 1;
        //        }
        //    }

        //    Sort((pivot + 1) - position, position);
        //    Sort(count - (pivot - position + 1), pivot + 1);

        //}
    }
}

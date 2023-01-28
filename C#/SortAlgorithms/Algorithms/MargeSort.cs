using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class MargeSort<T> : AlgorithmBase<T>
        where T : IComparable
    {
        public MargeSort(IEnumerable<T> items) : base(items) { }

        public MargeSort() { }

        protected override void MakeSort()
        {
            Items = Sort(Items);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }
            var mid = items.Count / 2;

            var left = items.Take(mid).ToList();
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var lenght = left.Count + right.Count;
            var leftPointer = 0;
            var rightPointer = 0;

            var result = new List<T>();

            for (int i = 0; i < lenght; i++)
            {
                if(leftPointer<left.Count && rightPointer < right.Count)
                {
                    if (Compare(left[leftPointer], right[rightPointer]) == -1)
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                    else
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                }
                else
                {
                    if(rightPointer < right.Count)
                    {
                        result.Add(right[rightPointer]);
                        rightPointer++;
                    }
                    else
                    {
                        result.Add(left[leftPointer]);
                        leftPointer++;
                    }
                }
            }
            return result;
        }
    }
}

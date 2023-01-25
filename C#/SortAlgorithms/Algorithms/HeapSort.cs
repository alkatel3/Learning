using Algorithms.DataSructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HeapSort<T> : Heap<T>
        where T : IComparable
    {
        public HeapSort(IEnumerable<T> items) : base(items) { }

        public HeapSort() { }

        protected override void MakeSort()
        {
            for(int i = Count; i >= 0; i--)
            {
                Sorted(i);
            }
            for (int i = Count-1; i>= 0; i--) {
                Swop(0, i);
                Sorted(0, i);
            }
        }
    }
}

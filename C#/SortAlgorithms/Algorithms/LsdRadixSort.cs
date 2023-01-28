using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class LsdRadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public LsdRadixSort(IEnumerable<T> items) : base(items) { }

        public LsdRadixSort() { }

        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }

            int length=GetMaxLength();

            for(int step = 0; step < length; step++)
            {
                foreach(var item in Items)
                {
                    var value = item.GetHashCode() % (int)Math.Pow(10,step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }
                Items.Clear();

                foreach(var group in groups)
                {
                    foreach(var item in group)
                    {
                        Items.Add(item);
                    }
                }
                foreach (var group in groups)
                {
                    group.Clear();
                }
            }
        }

        private int GetMaxLength()
        {
            var length = 0;

            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException();
                }
                var l = Convert.ToInt32(Math.Log10(item.GetHashCode() + 1));
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}

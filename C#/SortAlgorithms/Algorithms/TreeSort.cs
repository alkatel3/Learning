using Algorithms.DataSructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TreeSort<T>:Tree<T> where T : IComparable
    {
        public TreeSort(IEnumerable<T> items):base(items)
        {
        }
        protected override void MakeSort()
        {
            var sorted = Inorder().Select(i => i.Data).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Set(i, sorted[i]);
            }
        }
    }
}

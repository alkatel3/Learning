using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T>:AlgorithmBase<T>
        where T: IComparable
    {
        protected override void MakeSort()
        {
            for(int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;
                while (j > 0 && Compare(temp, Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                    SwopCount++;
                }
                Items[j] = temp;
            }
        }
        
    }
}

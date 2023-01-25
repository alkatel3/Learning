using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmBase<T>
        where T:IComparable
    {
        public CocktailSort(IEnumerable<T> items) : base(items) { }

        public CocktailSort() { }

        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                var sc = SwopCount;
                for(int i=left; i < right; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (Compare(a,b) == 1)
                    {
                        Swop(i, i + 1);
                    }
                    
                }
                if (sc == SwopCount)
                {
                    break;
                }
                right--;
                for(int i=right; i > left; i--)
                {
                    if (Compare(Items[i - 1], Items[i]) == 1)
                    {
                        Swop(i-1, i);
                    }
                }
                left++;
                if (sc == SwopCount)
                {
                    break;
                }
            }
        }
    }
}

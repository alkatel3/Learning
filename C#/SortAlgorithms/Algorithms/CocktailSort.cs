using System;

namespace Algorithms
{
    public class CocktailSort<T> : AlgorithmBase<T>
        where T:IComparable
    {
        protected override void MakeSort()
        {
            int left = 0;
            int right = Items.Count - 1;

            while(left < right)
            {
                var sc = SwopCount;
                for(int i=left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        ComparisonCount++;
                    }
                    
                }
                if (sc == SwopCount)
                {
                    break;
                }
                right--;
                for(int i=right; i > left; i--)
                {
                    if (Items[i-1].CompareTo(Items[i]) == 1)
                    {
                        Swop(i-1, i);
                        ComparisonCount++;
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

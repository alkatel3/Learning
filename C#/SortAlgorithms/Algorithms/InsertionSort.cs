using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class InsertionSort<T>:AlgorithmBase<T>
        where T: IComparable<T>
    {
        //My realization
        //
        //protected override void MakeSort()
        //{
        //    int LeftListCount = 1;
        //    int RightListCount = Items.Count - LeftListCount;
        //    int insertIndex = LeftListCount;

        //    while (RightListCount > 0)
        //    {
        //        for(int i = 0; i < LeftListCount; i++)
        //        {
        //            for(int j = insertIndex; j > 0; j--) 
        //            {
        //                if (Items[j].CompareTo(Items[j - 1]) == -1)
        //                {
        //                    Swop(j, j - 1);
        //                    ComparisonCount++;
        //                    continue;
        //                }
        //                break;
        //            }
        //        }
        //        LeftListCount++;
        //        RightListCount--;
        //        insertIndex++;
        //    }
        //}

         protected override void MakeSort()
         {
            for(int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];
                var j = i;
                while (j > 0 && temp.CompareTo(Items[j - 1]) == -1)
                {
                    Items[j] = Items[j - 1];
                    j--;
                    SwopCount++;
                    ComparisonCount++;
                }
                Items[j] = temp;
            }
        }
        
    }
}

using System;

namespace Algorithms
{
    public  class ShellSort<T> : AlgorithmBase<T>
        where T : IComparable
    {
        protected override void MakeSort()
        {

            int step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    var temp = Items[i];
                    var j = i;
                    while (j >= step && Compare(temp, Items[j - step]) == -1)
                    {
                        Items[j] = Items[j - step];
                        j -= step;
                        SwopCount++;
                    }
                    Items[j] = temp;
                }
                step /= 2;
            }

            //int step = Items.Count / 2;

            //while (step > 0)
            //{
            //    for (int i = step; i < Items.Count; i++)
            //    {
            //        int j = i;
            //        while (j >= step && Compare(Items[j - step], Items[j]) == 1)
            //        {
            //            Swop(j - step, j);
            //            j -= step;
            //        }
            //    }
            //    step /= 2;
            //}
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataSructures
{
    public class Heap<T> :AlgorithmBase<T> where T: IComparable
    {
        public int Count => Items.Count;

        public Heap() { }

        public Heap(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public void Add(T item)
        {
            Items.Add(item);

            var currentIndex = Count - 1;
            var parentIngex = GetParentIngex(currentIndex);

            while (currentIndex > 0 && Compare(Items[parentIngex], Items[currentIndex]) == -1)
            {
                Swop(currentIndex, parentIngex);
                currentIndex = parentIngex;
                parentIngex = GetParentIngex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);
            Sorted(0);
            return result;
        }

        protected void Sorted(int CurrentIndex, int maxLenght=-1)
        {
            int maxIndex = CurrentIndex;
            int leftIndex;
            int rightIndex;

            maxLenght = maxLenght == -1 ? Count : maxLenght;
            while (CurrentIndex < maxLenght)
            {
                leftIndex = 2 * CurrentIndex + 1;
                rightIndex = 2 * CurrentIndex + 2;
                if (rightIndex < maxLenght && Compare(Items[rightIndex],Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }
                if (leftIndex < maxLenght && Compare(Items[leftIndex],Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }
                if (maxIndex == CurrentIndex)
                {
                    break;
                }
                Swop(CurrentIndex, maxIndex);
                CurrentIndex = maxIndex;
            }
        }

        private static int GetParentIngex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public List<T> Order()
        {
            var result = new List<T>();
            while (Count > 0)
            {
                result.Add(GetMax());
            }
            return result;
        }

        
    }
}

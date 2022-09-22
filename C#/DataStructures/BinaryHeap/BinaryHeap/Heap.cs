
using System.Collections;

namespace BinaryHeap
{
    public class Heap <T>:IEnumerable<T>
        where T: IComparable<T>
    {
        private List<T>  Items=new List<T> ();

        public int Count => Items.Count;

        public Heap() { }

        public Heap(List<T> items)
        {
            Items.AddRange(items);
            for (int i = Count; i >= 0; i--)
            {
                Sort(i);
            }
        }

        public T Peak()
        {
            if (Count > 0)
            {
                return Items[0];
            }
            else
            {
                return default(T);
            }
        }

        public void Add(T item)
        {
            Items.Add(item);

            var currentIndex = Count - 1;
            var parentIngex = GetParentIngex(currentIndex);

            while (currentIndex > 0 && Items[parentIngex].CompareTo(Items[currentIndex]) == -1)
            {
                Swap(currentIndex, parentIngex);
                currentIndex = parentIngex;
                parentIngex = GetParentIngex(currentIndex);
            }
        }

        public T GetMax()
        {
            var result = Items[0];
            Items[0] = Items[Count - 1];
            Items.RemoveAt(Count - 1);

            Sort(0);
            return result;
        }

        private void Sort(int CurrentIndex)
        {
            int maxIndex = CurrentIndex;
            int leftIndex;
            int rightIndex;
            while (CurrentIndex < Count)
            {
                leftIndex = 2 * CurrentIndex + 1;
                rightIndex = 2 * CurrentIndex + 2;
                if(rightIndex<Count&&Items[rightIndex].CompareTo(Items[maxIndex]) == 1)
                {
                    maxIndex = rightIndex;
                }
                if (leftIndex < Count && Items[leftIndex].CompareTo(Items[maxIndex]) == 1)
                {
                    maxIndex = leftIndex;
                }
                if (maxIndex == CurrentIndex)
                {
                    break;
                }
                Swap(CurrentIndex, maxIndex);
                CurrentIndex = maxIndex;
            }
        }

        private void Swap(int currentIndex, int parentIngex)
        {
            var temp = Items[currentIndex];
            Items[currentIndex] = Items[parentIngex];
            Items[parentIngex] = temp;
        }

        private static int GetParentIngex(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            while (Count > 0)
            {
                yield return GetMax();
            }
        }
    }
}

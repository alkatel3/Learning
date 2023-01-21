using System;
using System.Collections;

namespace SortedArrayList
{
    class Sorted_Array_List:ArrayList
    {
        public void AddSorted(object item)
        {
            int position = BinarySearch(item);
            if (position < 0)
            {
                position = ~position;
            }
            Insert(position, item);
        }
        public void ModifySorted(object item, int index)
        {
            RemoveAt(index);
            int position = BinarySearch(item);
            if (position < 0)
            {
                position = ~position;
            }
            Insert(position, item);
        }
    }
}

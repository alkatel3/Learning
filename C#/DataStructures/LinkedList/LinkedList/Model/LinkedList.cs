using System.Collections;

namespace LinkedList.Model
{
    public class LinkedList<T>:IEnumerable<T>
    {
        /// <summary>
        /// First element of list
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Last element of list
        /// </summary>
        public Item<T> Tail { get; private set; }
        /// <summary>
        /// Count elements in list
        /// </summary>
        public int Count { get; private set; }
        /// <summary>
        /// Creating empty list
        /// </summary>
        public LinkedList()
        {
            Clear();
        }
        /// <summary>
        /// Creating list with first element
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
            Count++;
        }
        /// <summary>
        /// Adding data in start of list
        /// </summary>
        /// <param name="data"></param>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head=item;
            Count++;
        }
        /// <summary>
        /// Adding element in end of list
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Count==0)
            {
            SetHeadAndTail(item);
            }
            else
            {
                Tail.Next = item;
                Tail=item;
            }
            Count++;
        }
        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
        }
        /// <summary>
        /// Removing first element with value=data
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            if (Count != 0)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head;
                while(current.Next != null)
                {
                    if (current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        Count--;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        /// <summary>
        /// Insert data for index
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void InsertAt(T value, int index)
        {
            var item = new Item<T>(value);
            if (0 <= index && index <= Count) 
            {
                if (index == 0){
                    item.Next = Head;
                    Head = item;
                    Count++;
                }
                else if(index == Count)
                {
                    Add(value);
                }
                else
                {
                    int i = 1;
                    var current = Head;
                    while(i < Count)
                    {
                        if (i == index)
                        {
                            item.Next = current.Next;
                            current.Next = item;
                            Count++;
                            return;
                        }
                        i++;
                        current = current.Next;
                    }
                }
            }
        }
        /// <summary>
        /// Insert data after some element of list
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {

            if (Count != 0)
            {
                    var current = Head;
                while (current.Next != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        /// <summary>
        /// Insert range of data for index
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="index"></param>
        public void InsertRangeAt(T[] arr, int index)
        {
            foreach (T item in arr)
            {
                InsertAt(item, index);
                index++;
            }
        }
        /// <summary>
        /// Removing data for index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            if(0<=index&&index < Count)
            {
                if (index == 0)
                {
                    Head = Head.Next;
                    Count--;
                }
                else
                {
                    var current = Head;
                    int i = 1;
                    while(i < Count)
                    {
                        if (i == index)
                        {
                            current.Next = current.Next.Next;
                            Count--;
                        }
                        current = current.Next;
                        i++;
                    }
                }
            }
        }
        /// <summary>
        /// Removing range of data for index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public void RemoveRangeAt(int index, int count)
        {
            for (int i = 0; i < count; i++)
            {
                RemoveAt(index);
            }
        }
        /// <summary>
        /// Deleting all elements
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        /// <summary>
        /// Getting enumerator all elements of list
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}

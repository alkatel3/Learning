
using System.Collections;

namespace DoubleLinkedList
{
    public class DoubleLinkedList<T>:IEnumerable<T>
    {
        private Item<T> Head;
        private Item<T> Tail;

        public int Count { get; private set; } = 0;
        public bool IsEmpty => Count == 0;

        public DoubleLinkedList() {  }
        public DoubleLinkedList(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count++;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (!IsEmpty)
            {
                item.Previous = Tail;
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                Head = item;
                Tail = item;
                Count++;
            }
        }

        public void Delete(T data)
        {
            if (!IsEmpty)
            {
                if (Head.Data.Equals(data))
                {
                    if (Count > 1)
                    {
                        Head.Next.Previous = null;
                        Head = Head.Next;
                        Count--;
                        return;
                    }
                    else
                    {
                        Head = null;
                        Tail = null;
                        Count=0;
                        return;
                    }
                }
                var current = Head;
                int i = 1;
                while (i < Count)
                {
                    if (current.Data.Equals(data))
                    {
                        current.Previous.Next = current.Next;
                        current.Next.Previous = current.Previous;
                        Count--;
                        return;
                    }
                    current = current.Next;
                    i++;
                }
                if (Tail.Data.Equals(data))
                {
                    Tail.Previous.Next = null;
                    Tail = Tail.Previous;
                    Count--;
                    return;
                }
            }
        }

        public DoubleLinkedList<T> Reverse()
        {
            var result = new DoubleLinkedList<T>();
            var current = Tail;
            while(current != null)
            {
                result.Add(current.Data);
                current = current.Previous;
            }
            return result;

        }

        public IEnumerator<T> GetEnumerator()
        {
            var Current = Head;
            while (Current != null)
            {
                yield return Current.Data;
                Current = Current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var Current = Head;
            while (Current != null)
            {
                yield return Current.Data;
                Current = Current.Next;
            }
        }
    }
}

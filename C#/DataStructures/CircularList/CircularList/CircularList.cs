
using System.Collections;

namespace CircularList
{
    public class CircularList<T>:IEnumerable<T>
    {
        private Item<T> Head;

        public int Count { get; private set; } = 0;
        public bool isEmpty=>Count==0;

        public CircularList()
        {
            Head = null;
        }

        public CircularList(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Head.Next = Head;
            Head.Previos = Head;
            Count++;
        }

        public void Add(T data)
        {
            if (!isEmpty)
            {
                var item=new Item<T>(data);
                item.Next = Head;
                item.Previos = Head.Previos;
                Head.Previos.Next = item ;
                Head.Previos = item;
                Count++;
            }
            else
            {
                SetHeadItem(data);
                return;
            }
        }
        public void Delete(T data)
        {
            if (Head.Data.Equals(data))
            {
                RemoveItem(Head);
                Head = Head.Next;
                return;
            }
            var current = Head;
            for(int i=Count; i>=0; i--)
            {
                if (current!=null && current.Data.Equals(data))
                {
                    RemoveItem(current);
                    return;
                }
                current = current.Next;
            }
        }

        private void RemoveItem(Item<T> current)
        {
            current.Previos.Next = current.Next;
            current.Next.Previos = current.Previos;
            Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            for(int i=Count; i > 0; i--)
            {
                yield return current.Data;
                current=current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
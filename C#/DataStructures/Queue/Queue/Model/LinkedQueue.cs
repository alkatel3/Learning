
namespace Queue.Model
{
    public class LinkedQueue<T>
    {
        private Item<T> Head;
        private Item<T> Tail;

        public int Count { get; private set; }

        public LinkedQueue() { }

        public LinkedQueue(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
         {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }
            var item = new Item<T>(data);
            Tail.Next = item;
            Tail = item;
            Count++;
        }

        public T Dequeue()
        {
            if (Count > 0)
            {
                var data = Head.Data;
                Head = Head.Next;
                Count--;
                return data;
            }
            throw new ArgumentOutOfRangeException();
        }

        public T Peek()
        {
            return Head.Data;
        }
    }
}

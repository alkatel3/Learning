
namespace MyStack_2.Model
{
    public class HardStack<T>
    {
        private Item<T> Head;
        public int Count { get; set; }
        public bool IsEmpty=>Count == 0;

        public HardStack()
        {
            Head = null;
            Count = 0;
        }
        public HardStack(T data)
        {
            Head = new Item<T> (data);
            Count = 1;
        }

        public void Push(T data)
        {
            var item = new Item<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = Head;
                Head = Head.Previous;
                Count--;
                return item.Data;

            }
            else
            {
                throw new ArgumentOutOfRangeException("Stack is empty");
            }
        }
        public T Peak()
        {
            if (!IsEmpty)
            {
                return Head.Data;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Stack is empty");
            }
        }

        public override string ToString()
        {
            return $"Stack with {Count} elements";
        }
    }
}

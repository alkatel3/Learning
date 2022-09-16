namespace MyStack_1.Model
{
    public class EasyStack<T>:ICloneable
    {
        private List<T> Items = new List<T>();
        public int Count => Items.Count;
        public bool IsEmpty=>Items.Count == 0;

        public void Push(T item)
        {
            Items.Add(item);
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = Items[Items.Count - 1];
                Items.RemoveAt(Items.Count - 1);
                return item;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public T Peak()
        {
            if (!IsEmpty)
            {
                return Items[Items.Count - 1];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public void Clear()
        {
            Items.Clear();
        }
        public override string ToString()
        {
            return $"Stack with {Count} of element";
        }

        public object Clone()
        {
            var newStack=new EasyStack<T>();
            newStack.Items = new List<T>(Items);
            return newStack;
        }
    }
}

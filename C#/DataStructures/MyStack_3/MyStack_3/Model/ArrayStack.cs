using System;
namespace MyStack_3.Model
{
    public class ArrayStack<T>
    {
        private T[] items;
        private int current=-1;
        public bool IsEmpty =>current<0;
        public int Count => current + 1;
        public int MaxCount=>items.Length;
        public ArrayStack(int size=10)
        {
            items = new T[size];
        }
        public ArrayStack(T data,int size = 10):this(size)
        {
            items.Append(data);
            current++;
        }

        public void Push(T item)
        {
            if (current+1<items.Length)
            {
                current++;
                items[current]=item;

            }
            else
                throw new StackOverflowException();
        }
        public T Pop()
        {
            if (current >= 0)
            {
                var item = items[current ];
                items[current] = default(T);
                current--;
                return item;
            }
            else
                throw new ArgumentOutOfRangeException();
        }
        public T Peak()
        {
            if (current >= 0)
            {
                return items[current];
            }
            else
                throw new ArgumentOutOfRangeException();
        }
        public override string ToString()
        {
            return $"Stack with {current+1} elements";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BidirectionalList
{
    class MyList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public void AddLast(T val)
        {
            var tmp = new Node<T>() { Date = val };
            if (Count == 0)
                Head = Tail = tmp;
            else
            {
                Tail.Next = tmp;
                tmp.Prev = Tail;
                Tail = tmp;
            }
            Count++;
        }
        
        public void AddFirst(T val)
        {
            var tmp = new Node<T>() { Date = val };
            if (Count == 0)
                Head = Tail = tmp;
            else
            {
                Head.Prev = tmp;
                tmp.Next = Head;
                Head = tmp;
            }
            Count++;
        }

        public void InsertAt(T val, int index)
        {
            if (index == Count)
                AddLast(val);
            else if (index == 0)
                AddFirst(val);
            else
            {
                int i = 0;
                var ins = Head;
                while (i < index)
                {
                    ins = ins.Next;
                    i++;
                }
                var prevIns = ins.Prev;
                var tmp = new Node<T>() { Date = val };
                //if (/*prevIns != null &&*/ Count != 1)
                //{
                tmp.Next = ins;
                tmp.Prev = prevIns;
                ins.Prev = tmp;
                prevIns.Next = tmp;
                Count++;
                //}
            }
        }

        public void InsertRangeAt(T[] arr, int index)
        {
            foreach(T item in arr)
            {
                InsertAt(item, index);
                index++;
            }
        }

        //Check
        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if (Count == 0)
                {
                    Tail = null;
                }
                else
                {
                    Head.Prev = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                Tail = Tail.Prev;
                Count--;
                if (Count == 0)
                    Head = null;
                else
                    Tail.Next = null;
            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                RemoveFirst();
            }
            else if (index == Count - 1)
            {
                RemoveLast();
            }
            else
            {
                var current = Head;
                for(int i =0; i<index-1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                current.Next.Prev = current;
                Count--;
            }
        }

        public void RemoveRangeAt(int index, int count)
        {
            for(int i = 0; i < count; i++)
            {
                RemoveAt(index);
            }
        }

        public void PrintForward()
        {
            var cur = Head;
            while (cur != null)
            {
                Console.Write($"{cur.Date} ");
                cur = cur.Next;
            }
            Console.WriteLine();
        }


        public IEnumerator<T> GetEnumerator()
        {
            var cur = Head;
            while (cur != null)
            {
                yield return cur.Date;
                cur = cur.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

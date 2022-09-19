using Queue.Model;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eazyQueue = new EasyQueue<int>();

            eazyQueue.Enqueue(1);
            eazyQueue.Enqueue(2);
            eazyQueue.Enqueue(3);
            eazyQueue.Enqueue(4);
            eazyQueue.Enqueue(5);

            Console.WriteLine(eazyQueue.Dequeue());
            Console.WriteLine(eazyQueue.Peek());
            Console.WriteLine(eazyQueue.Dequeue());
            Console.WriteLine(eazyQueue.Dequeue());
            Console.WriteLine(eazyQueue.Dequeue());
            Console.ReadLine();
            var arrayQueue = new ArrayQueue<int>(10);

            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.ReadLine();

            var linkedQueue = new LinkedQueue<int>();

            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            linkedQueue.Enqueue(5);

            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Peek());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.WriteLine(linkedQueue.Dequeue());
            Console.ReadLine();

            var easyDeque = new EasyDeque<int>();

            easyDeque.PushFront(1);
            easyDeque.PushFront(2);
            easyDeque.PushFront(3);
            easyDeque.PushBack(40);
            easyDeque.PushBack(50);
            easyDeque.PushFront(600);
            easyDeque.PushBack(700);

            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.WriteLine(easyDeque.PopFront());
            Console.WriteLine(easyDeque.PopBack());
            Console.ReadLine();

            var duplexLinkedDeque = new DuplexLinkedDeque<int>();

            duplexLinkedDeque.PushFront(1);
            duplexLinkedDeque.PushFront(2);
            duplexLinkedDeque.PushFront(3);
            duplexLinkedDeque.PushBack(40);
            duplexLinkedDeque.PushBack(50);
            duplexLinkedDeque.PushFront(600);
            duplexLinkedDeque.PushBack(700);

            Console.WriteLine(duplexLinkedDeque.PopFront());
            Console.WriteLine(duplexLinkedDeque.PopBack());
            Console.WriteLine(duplexLinkedDeque.PopFront());
            Console.WriteLine(duplexLinkedDeque.PopBack());
            Console.ReadLine();
        }
    }
}
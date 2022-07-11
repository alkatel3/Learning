using System;
namespace BidirectionalList
{
    class Node<T>
    {
        public T Date { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
    }
}

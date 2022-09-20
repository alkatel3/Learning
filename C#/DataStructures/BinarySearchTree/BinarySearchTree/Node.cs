
namespace BinarySearchTree
{
    public class Node<T> :IComparable<Node<T>>  
        where T : IComparable<T>
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data):this(data, null, null) { }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public void Add(T data)
        {
            var node =new Node<T>(data);
            if (node.Data.CompareTo(Data) == -1)
            {
                if(Left == null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(node.Data);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(node.Data);
                }
            }
        }

        public int CompareTo(Node<T> other)
        {
            return Data.CompareTo(other.Data);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

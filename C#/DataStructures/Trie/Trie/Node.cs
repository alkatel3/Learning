
namespace Trie
{
    internal class Node<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }

        public bool IsWord { get; set; } 

        public string Prefix { get; set; }



        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data, string prefix)
        {
            Symbol = symbol;
            Data = data;
            Prefix = prefix;
            SubNodes = new Dictionary<char, Node<T>>();
        }

        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] ({Prefix})";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Node<T> node)
            {
                return Data.Equals(node);
            }
            else
            {
                return false;
            }
        }

        public Node<T> TryFind(char symbol)
        {
            if(SubNodes.TryGetValue(symbol, out Node<T> node))
            {
                return node;
            }
            else
            {
                return null;
            }
        }
    }
}


namespace Trie
{
    public class Trie<T>
    {
        private Node<T> root;
        public int Count { get; set; }

        public Trie()
        {
            root = new Node<T>('\0', default(T),"");
            Count=1;
        }

        public void Add(string key, T data)
        {
            AddNode(key, data, root);
        }

        private void AddNode(string key, T data, Node<T> node)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
            }
            else
            {
                var symbol = key[0];
                var subnode = node.TryFind(symbol);
                if (subnode != null)
                {
                    AddNode(key.Substring(1), data, subnode);
                }
                else
                {
                    var newNode = new Node<T>(key[0], data, node.Prefix + key[0]);
                    node.SubNodes.Add(key[0], newNode);
                    AddNode(key.Substring(1), data, newNode);

                }
            }
        }

        public void Remove(string key)
        {
            RemoveNode(key, root);
        }

        private void RemoveNode(string key, Node<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                }
            }
            else
            {
                var subNode = node.TryFind(key[0]);
                if (subNode != null)
                {
                    RemoveNode(key.Substring(1), subNode);
                }
            }
        }

        public bool TrySearch(string key, out T value)
        {
           return SearchNode(key, root, out value);
        }


        private bool SearchNode(string key, Node<T> node, out T value)
        {
            value = default(T);
            var result = false;
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    value = node.Data;
                    result = true;
                }
            }
            else
            {
                var subNode = node.TryFind(key[0]);
                if (subNode != null)
                {
                   result= SearchNode(key.Substring(1), subNode,out value);
                }
            }
            return result;
        }
    }
}

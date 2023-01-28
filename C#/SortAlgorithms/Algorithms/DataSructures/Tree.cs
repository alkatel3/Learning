using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.DataSructures
{
    public class Tree<T> : AlgorithmBase<T> where T : IComparable
    {
        private Node<T> Root { get; set; }
        public int Count { get; private set; } = 0;

        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            var list = items.ToList();
            for (int i = 0; i < items.Count(); i++)
            {
                var item = list[i];
                Items.Add(item);
                var node = new Node<T>(item, i);
                Add(node);
            }
        }

        private void Add(Node<T> node)
        {
            if (Root == null)
            {
                Root = node;
                Count=1;
                return;
            }
            Add(Root, node);
            Count++;
        }

        public List<Node<T>> Inorder()
        {
            return Inorder(Root);
        }

        private List<Node<T>> Inorder(Node<T> node)
        {
            var result = new List<Node<T>>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    result.AddRange(Inorder(node.Left));
                }
                result.Add(node);
                if (node.Right != null)
                {
                    result.AddRange(Inorder(node.Right));
                }
            }
            return result;
        }

        private void Add(Node<T> node, Node<T> newNode)
        {
            if (Compare(node.Data, newNode.Data) == 1)
            {
                if (node.Left == null)
                {
                    node.Left = newNode;
                }
                else
                {
                    Add(node.Left, newNode);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = newNode;
                }
                else
                {
                   Add(node.Right,newNode);
                }
            }
        }
    }
}

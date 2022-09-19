using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class BadHashTable<T>
    {
        private T[] items;

        public BadHashTable(int size)
        {
            items = new T[size];
        }

        public void Add(T item)
        {
            var key = GetHash(item);
            items[key] = item;
        }

        public bool Search(T item)
        {
            var key=GetHash(item);
            return items[key]?.Equals(item)??false;
        }

        private int GetHash(T item)
        {
            return item.ToString().Length % items.Length;
        }
    }
}

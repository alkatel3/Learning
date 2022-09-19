using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Item<T>
    {
        public int key { get; set; }
        public List<T> Nodes { get; set; }

        public Item(int key)
        {
            Nodes = new List<T>();
            this.key = key;
        }
    }
}

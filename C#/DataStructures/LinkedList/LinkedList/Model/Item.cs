using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class Item<T>
    {
        private T data=default(T);
        /// <summary>
        /// Specifies the next element after the current one.
        /// </summary>
        public Item<T> Next { get; set; }
        /// <summary>
        /// Sets the data of the current element
        /// </summary>
        public T Data
        {
            get { return data; }
            set {data = value??throw new ArgumentNullException(nameof(value)); }
        }
        /// <summary>
        /// Створює новий елемент типу Item<T>
        /// </summary>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public Item(T data)
        {
            if(data == null) throw new ArgumentNullException(nameof(data));
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

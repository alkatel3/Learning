
using System.Collections;

namespace Dictionary
{
    public class Dict<TKey,TValue>:IEnumerable
    {
        private int size = 100;
        private Item<TKey, TValue>[] Items;
        private List<TKey> Keys = new List<TKey>();

        private int increase = 2;

        public int Increase
        {
            get { return increase; }
            set 
            {
                if (value > 1)
                {
                    increase = value;
                }
            }
        }
        public Dict() 
        {
            Items = new Item<TKey, TValue>[size];
        }

        public void Add(Item<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);
            if (Keys.Contains(item.Key))
            {
                return;
            }
            if (Items[hash] == null)
            {
                Keys.Add(item.Key);
                Items[hash] = item;
            }
            else
            {
                var plased = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        Keys.Add(item.Key);
                        Items[i] = item;
                        plased = true;
                        break;
                    }

                }
                if (!plased)
                {
                    for(int i=0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            Keys.Add(item.Key);
                            Items[i] = item;
                            plased = true;
                            break;
                        }
                    }
                }
                if (!plased)
                {
                    var newItems=new Item<TKey, TValue>[size * increase];
                    for(int i=0; i < size;i++)
                    {
                        newItems[i] = Items[i];
                    }
                    Items = newItems;
                    size = newItems.Length;
                    Add(item);
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var item in Items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return;
            }

            if (Items[hash] == null)
            {
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i]?.Key.Equals(key)??false)
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }
                return;
            }
            if (Items[hash].Key.Equals(key))
            {
                Items[hash] =null;
                Keys.Remove(key);
            }
            else
            {
                var plased = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return;
                    }
                    if (Items[i].Key.Equals(key))
                    {
                        Items[i] = null;
                        Keys.Remove(key);
                        return;
                    }
                }
                if (!plased)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return;
                        }
                        if (Items[i].Key.Equals(key))
                        {
                            Items[i] = null;
                            Keys.Remove(key);
                            return;
                        }
                    }
                }
            }
        }

        public TValue Search(TKey key)
        {
            var hash = GetHash(key);

            if (!Keys.Contains(key))
            {
                return default(TValue);
            }

            if (Items[hash] == null)
            {
                for (int i = 0; i < Items.Length; i++)
                {
                    if (Items[i].Key.Equals(key))
                    {
                        return Items[i].Value;
                    }
                }
                return default(TValue);
            }
            if (Items[hash].Key.Equals(key))
            {
                return Items[hash].Value;
            }
            else
            {
                var plased = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return default(TValue);
                    }
                    if (Items[i].Key.Equals(key))
                    {
                        return Items[i].Value;
                    }
                }
                if (!plased)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }
                        if (Items[i].Key.Equals(key))
                        {
                            return Items[i].Value;
                        }
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }
                    }
                }
            }
            return default(TValue);
        }

        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}

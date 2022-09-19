
using System.Collections;

namespace Set
{
    public class EasySet<T>:IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public int Count=> items.Count;

        public EasySet() { }

        public EasySet(T item)
        {
            items.Add(item);
        }

        public EasySet(IEnumerable<T> items)
        {
            this.items = items.ToList();        }

        public void Add(T item)
        {
            if (items.Contains(item))
            {
                return;
            }
            //foreach(var i in items)
            //{
            //    if (i.Equals(item))
            //    {
            //        return;
            //    }
            //}
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public EasySet<T> Union(EasySet<T> set)
        {
            //return new EasySet<T>(items.Union(set.items));

            EasySet<T> result = new EasySet<T>();
            foreach (var item in items)
            {
                result.Add(item);
            }
            foreach (var item in set.items)
            {
                result.Add(item);
            }
            return result;
        }

        public EasySet<T> Intersection(EasySet<T> set)
        {
            //return new EasySet<T>(items.Intersect(set.items));

            var result = new EasySet<T>();
            EasySet<T> bigger=set;
            EasySet<T> smaller = this;
            if (Count >= set.Count)
            {
                smaller = set;
                bigger = this;
            }
            foreach (var item1 in smaller.items)
            {
                foreach(var item2 in bigger.items)
                {
                    if (item1.Equals(item2))
                    {
                        result.Add(item2);
                        break;
                    }
                }
            }
            return result;
        }

        public EasySet<T> Difference(EasySet<T> set)
        {
            //return new EasySet<T>(items.Except(set.items));

            var result = new EasySet<T>(items);
            foreach(var item in set.items)
            {
                result.Remove(item);
            }
            return result;
        }

        public bool SubSet(EasySet<T> set)
        {
            //return set.items.All(i => items.Contains(i));
            if (Count >= set.Count)
            {
                foreach (var item1 in set.items)
                {
                    var check = false;
                    foreach(var item2 in items)
                    {
                        if (item1.Equals(item2))
                        {
                            check = true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public EasySet<T> SymmetricDifference(EasySet<T> set)
        {
            return Union(set).Difference(Intersection(set));
            //return new EasySet<T>(items.Except(set.items).Union(set.items.Except(items)));
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

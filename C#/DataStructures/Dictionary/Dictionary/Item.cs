
namespace Dictionary
{
    public class Item<Tkey, TValue>
    {
        public Tkey Key { get; set; }
        public TValue Value { get; set; }

        public Item(Tkey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}

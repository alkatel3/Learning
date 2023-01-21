using System;

namespace Exception01
{
    class RangeArray
    {
        int[] a;
        int lowerBound;
        int upperBound;

        public int Length { get; private set; }

        public RangeArray(int low,int high)
        {
            high++;
            if (high <= low)
            {
                throw new RangeArrayException("Нижня границя бiльша за верхню");
            }
            a = new int[high - low];
            Length = high - low;
            lowerBound = low;
            upperBound = --high;
        }
        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    return a[index - lowerBound];
                }
                throw new RangeArrayException("Помилка порушення границь");
            }
            set
            {
                if (ok(index))
                {
                    a[index - lowerBound] = value;
                }
                else
                {
                    throw new RangeArrayException("Помилка порушення границь");
                }
            }
        }
        bool ok(int index)
        {
            if (index >= lowerBound && index <= upperBound)
            {
                return true;
            }
            return false;
        }
    }
}

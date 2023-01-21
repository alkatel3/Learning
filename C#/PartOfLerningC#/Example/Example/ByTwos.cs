using System;


namespace Example
{
    class ByTwos : ISeries 
    {
        int start;
        int val;
        int prev;

        public ByTwos()
        {
            prev = -2;
            start = 0;
            val = 0;
        }

        public int GetNext()
        {
            prev = val;
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
            prev = start - 2;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
            prev = val - 2;
        }
        public int GetPrevious()
        {
            return prev;
        }
    }
}

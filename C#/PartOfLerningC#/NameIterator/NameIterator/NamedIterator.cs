using System;
using System.Collections;
using System.Collections.Generic;

namespace NameIterator
{
    class NamedIterator
    {
        const int LIM = 10;
        int _limit;

        public NamedIterator(int limit)
        {
            _limit = limit;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i=0; i<_limit; i++)
            {
                if (i == LIM)
                {
                    yield break;
                }
                yield return i;
            }
        }
        public IEnumerable<int> GetRange(int start)
        {
            for(int i=start; i <= _limit; i++)
            {
                if (i == LIM)
                {
                    yield break;
                }
                yield return i;
            }
        }
    }
}

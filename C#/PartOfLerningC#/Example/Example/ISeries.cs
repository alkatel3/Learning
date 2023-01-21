using System;


namespace Example
{
    interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
}

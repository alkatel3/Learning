using System;
using System.Diagnostics;
using static System.Console;

namespace OperationTimer
{
    internal sealed class Operation_Timer : IDisposable
    {
        long _startTime;
        string _text;
        int _collectionCount;

        public Operation_Timer(string text)
        {
            PrepareForOperation();

            _text = text;
            _collectionCount = GC.CollectionCount(0);
            _startTime = Stopwatch.GetTimestamp();

        }

        public void Dispose()
        {
            WriteLine($"{_text}\t{(Stopwatch.GetTimestamp() - _startTime) / (double)Stopwatch.Frequency:0.00} second" +
                $" (GC {GC.CollectionCount(0) - _collectionCount})");
        }
        private static void PrepareForOperation()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}

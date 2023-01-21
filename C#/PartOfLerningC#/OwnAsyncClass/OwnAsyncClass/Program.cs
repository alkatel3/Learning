namespace OwnAsyncClass
{
    internal class Program
    {
        private delegate ulong AsyncSumDel(ulong n);
        static void Main(string[] args)
        {
            AsyncSumDel del= Sum;
            del.BeginInvoke(100000, EndSum, del);
            Console.ReadKey();
        }

        public static UInt64 Sum(UInt64 n)
        {
            UInt64 sum = 1;
            for (UInt64 i = 2; i < n; ++i)
                sum += i;
            return sum;
        }
        private static void EndSum(IAsyncResult asyncResult)
        {
            AsyncSumDel del=(AsyncSumDel)asyncResult.AsyncState;
            ulong res = del.EndInvoke(asyncResult);

            Console.WriteLine("Sum = " + res);
        }
    }
}
using System;


namespace Event
{
    class AccountEventArgs
    {
        public string Message { get; }
        public int Sum { get; }
        public string V { get; }

        public AccountEventArgs(string mes,int sum)
        {
            Message = mes;
            Sum = sum;
        }

        public AccountEventArgs(string v)
        {
            V = v;
        }
    }
}

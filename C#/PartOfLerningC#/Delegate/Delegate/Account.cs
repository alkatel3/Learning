using System;


namespace Delegate
{
    delegate void AccountStateHendler(string message);
    class Account
    {
        int _sum;
        AccountStateHendler _del;
        public void RegisterHandler(AccountStateHendler del)
        {
            _del += del;
        }
        public void UnregisterHandler(AccountStateHendler del)
        {
            _del -= del;
        }
        public Account (int sum)
        {
            _sum = sum;
          
        }
        public void put(int sum)
        {
            _sum += sum;
            _del?.Invoke($"Ваш рахунок поповнено на {sum}");
            Console.WriteLine();
        }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                _del?.Invoke($"З вашого рахунку знято {sum}");
                Console.WriteLine();
            }
            else
            {
                _del?.Invoke("На вашому рахунку не достатньо коштiв");
                Console.WriteLine();
            }
        } 

    }
}

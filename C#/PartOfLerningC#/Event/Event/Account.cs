using System;

namespace Event
{
    class Account
    {
       public delegate void Message(object sender,AccountEventArgs e);
        public event Message Text;

       public int Sum { get; private set; } 
        public Account(int sum)
        {
            Sum = sum;
        }
        public void Add(int sum)
        {
            Sum += sum;

            Text?.Invoke(this, new AccountEventArgs($"На ваш рахунок нараховано: {sum}"));
         
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;

                Text?.Invoke(this,new AccountEventArgs ($"З вашого рахунку знято: {sum}"));

            }
            else
            {

                Text?.Invoke(this, new AccountEventArgs("На вашому рахунку не достатньо коштiв"));
            }
        }
    }
}

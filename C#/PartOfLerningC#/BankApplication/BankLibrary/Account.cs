using System;


namespace BankLibrary
{
    public class Account:IAccount
    {
        protected internal event AccountStateHandler Withdrawed;
        
        protected internal event AccountStateHandler Added;
        
        protected internal event AccountStateHandler Opened;
        
        protected internal event AccountStateHandler Closed;
       
        protected internal event AccountStateHandler Calculated;

        static int counter = 0;
        protected int _days = 0; 

        public Account(decimal sum,int percentage)
        {
            Sum = sum;
            Percentage = percentage;
           Id =+counter;
        }
        public decimal Sum { get; private set; }
        public int Percentage { get; private set; }
        public int Id { get; private set; }
        private void CallEvent(AccountEventArgs e, AccountStateHandler handler)
        {
            if (e != null)
            { 
                handler?.Invoke(this, e);
            }
        }
        protected virtual void OnOpened(AccountEventArgs e)
        {
            CallEvent(e, Opened);
        }
        protected virtual void OnWithdrawed(AccountEventArgs e)
        {
            CallEvent(e, Withdrawed);
        }
        protected virtual void OnAdded(AccountEventArgs e)
        {
            CallEvent(e, Added);
        }
        protected virtual void OnCalculated(AccountEventArgs e)
        {
            CallEvent(e, Calculated);
        }
        protected virtual void OnClosed(AccountEventArgs e)
        {
            CallEvent(e, Closed);
        }
        public virtual void Put (decimal sum)
        {
            Sum += sum;
            OnAdded(new AccountEventArgs("На рахунок нараховано" + sum, sum));
        }
        public virtual decimal Withdraw(decimal sum)
        {
            decimal result = 0;
            if (sum >= Sum)
            {
                Sum -= sum;
                result = sum;
                OnWithdrawed(new AccountEventArgs("З рахунку знято " + sum, sum));
            }
            else
            {
                OnWithdrawed(new AccountEventArgs("На рахунку не достатньо кошiв", 0));
            }
            return result;
        } 
        protected internal virtual void Open()
        {
            OnOpened(new AccountEventArgs($"Вiдкритий новий рахунок\t ID:{Id}",Sum)) ;
        }
        protected internal virtual void Close()
        {
            OnClosed(new AccountEventArgs($"Рахунок {Id} закрито. Пiдсумкова сума: {Sum}", Sum));
        }
        protected internal virtual void IncrementDays()
        {
            _days++;
        }
        protected internal virtual void Calculate()
        {
            decimal increment = Sum * Percentage / 100;
            Sum += increment;
            OnCalculated(new AccountEventArgs($"Нараховано вiдсотки в розмiрi{increment}", increment));
        }
    }
}

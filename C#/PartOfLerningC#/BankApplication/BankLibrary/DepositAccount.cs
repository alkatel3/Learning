using System;


namespace BankLibrary
{
   public class DepositAccount:Account
    {
        public DepositAccount(decimal sum, int percentage) : base(sum, percentage)
        {
        }
        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Вiдкрито новий депозитний рахунок ID: {this.Id}", this.Sum));
        }
        public override void Put(decimal sum)
        {
            if (_days % 30 == 0)
            {
                base.Put(sum);
            }
            else
            {
                base.OnAdded(new AccountEventArgs("Рахунок можна поповнити через 30 днiв", 0));
            }
        }
        public override decimal Withdraw(decimal sum)
        {
            if (_days % 30 == 0)
                return base.Withdraw(sum);
            else
                base.OnWithdrawed(new AccountEventArgs("Вивести кошти можн через 30 днiв", 0));
            return 0;
        }
        protected internal override void Calculate()
        {
            if (_days % 30 == 0)
            {
                base.Calculate();
            }
        }
    }
}


using System;


namespace BankLibrary
{
    public class DemandAccount : Account
    {
        public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
        {

        }
        protected internal override void Open()
        {
            base.OnOpened(new AccountEventArgs($"Вiдкритий новий рахунок! Id рахунку: {this.Id}", this.Sum));
        }
    }
        
}

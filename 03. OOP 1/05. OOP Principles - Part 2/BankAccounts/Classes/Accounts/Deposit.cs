namespace BankAccounts.Classes.Accounts
{
    using BankAccounts.Classes.Accounts.Interfaces;
using BankAccounts.Classes.Customer;
    class Deposit : Account, IAccount, IDepositable, IWithdrawable
    {
        public Deposit(ICustomer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > 0 && this.Balance < 0)
            {
                return 0;
            }
            return base.CalculateInterest(months);
        }
        public void WithDraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}

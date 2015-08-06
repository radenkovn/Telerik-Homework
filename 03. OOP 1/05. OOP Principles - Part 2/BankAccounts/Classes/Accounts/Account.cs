namespace BankAccounts.Classes.Accounts
{
    using BankAccounts.Classes.Accounts.Interfaces;
    using BankAccounts.Classes.Customer;
    abstract class Account : IAccount
    {
        public Account(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public ICustomer Customer { get; protected set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; protected set; }
        public virtual decimal CalculateInterest(int months)
        {
            return this.Balance *this.InterestRate * months / 100;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} - Money: {1} - Interest rate: {2}", this.Customer, this.Balance, this.InterestRate);
        }

    }
}

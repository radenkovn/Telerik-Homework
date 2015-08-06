namespace BankAccounts.Classes.Accounts
{
    using BankAccounts.Classes.Accounts.Interfaces;
    using BankAccounts.Classes.Customer;
    class Loan : Account, IAccount, IDepositable
    {
        public Loan(ICustomer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {

        }
        public override decimal CalculateInterest(int months)
        {
            int actualMonths = months - 2;
            actualMonths = MonthCheker(actualMonths);
            if (this.Customer is IndividualCustomer)
            {
                --actualMonths;
                actualMonths = MonthCheker(actualMonths);
            }
            return base.CalculateInterest(actualMonths);
        }
        private int MonthCheker(int month)
        {
            if (month < 0)
            {
                month = 0;
            }
            return month;
        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
    }
}

namespace BankAccounts.Classes.Accounts
{
    using BankAccounts.Classes.Customer;
    using BankAccounts.Classes.Accounts.Interfaces;
    class Mortgage : Account, IDepositable
    {
        public Mortgage(ICustomer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {

        }

        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
        public override decimal CalculateInterest(int months)
        {
            decimal output=0;
            if (this.Customer is CompanyCustomer)
            {
                if (months > 12)
                {
                    output += base.CalculateInterest(12) / 2;
                    output += base.CalculateInterest(months - 12);
                }
                else
                {
                    output += base.CalculateInterest(months)/2;
                }
            }
            if (this.Customer is IndividualCustomer)
            {
                if (months > 6)
                {
                    output += base.CalculateInterest(months - 6);
                }
                else
                {
                    output = 0;
                }
            }
            return output;
        }
    }
}

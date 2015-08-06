namespace BankAccounts.Classes.Customer
{
    public class CompanyCustomer : Customer, ICustomer
    {
        public CompanyCustomer(string name)
            : base(name)
        {
            this.Individual = false;
        }

    }
}

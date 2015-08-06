namespace BankAccounts.Classes.Customer
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string name)
            : base(name)
        {
            this.Individual = true;
        }
    }
}

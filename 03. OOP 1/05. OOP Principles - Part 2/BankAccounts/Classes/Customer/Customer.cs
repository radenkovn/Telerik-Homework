namespace BankAccounts.Classes.Customer
{
    public abstract class Customer : ICustomer
    {
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name { get; protected set; }
        public bool Individual { get; protected set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}

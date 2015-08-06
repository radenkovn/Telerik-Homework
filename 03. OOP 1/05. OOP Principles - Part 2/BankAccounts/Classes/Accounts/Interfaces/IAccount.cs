namespace BankAccounts.Classes.Accounts.Interfaces
{
    using BankAccounts.Classes.Customer;
    public interface IAccount
    {
        ICustomer Customer { get; }
        decimal Balance { get; }
        decimal InterestRate { get; }
        decimal CalculateInterest(int months);
    }
}

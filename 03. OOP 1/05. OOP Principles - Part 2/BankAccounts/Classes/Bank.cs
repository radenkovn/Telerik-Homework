namespace BankAccounts.Classes
{
    using System;
    using System.Collections.Generic;

    using BankAccounts.Classes.Customer;
    using BankAccounts.Classes.Accounts;
    using BankAccounts.Classes.Accounts.Interfaces;


    public class Bank
    {
        private List<IAccount> bankAccounts;
        public Bank(List<IAccount> bankAccounts)
        {
            this.bankAccounts = bankAccounts;
        }
        public List<IAccount> BankAccounts { get { return this.bankAccounts; } } 
        public void AddAccount(IAccount acc)
        {
            this.bankAccounts.Add(acc);
        }
        public void RemoveAccount(IAccount acc)
        {
            this.bankAccounts.Remove(acc);
        }
        public void ListAllAccounts()
        {
            Console.WriteLine("All accounts in the bank: ");
            foreach (var acc in this.bankAccounts)
            {
                Console.WriteLine(acc);
            }
        }
        public void InterestForAll(int month)
        {
            Console.WriteLine("\nInterest for every account for {0} months:", month);
            foreach (var account in this.BankAccounts)
            {
                Console.WriteLine("AccountInterest {0} - {1}", account.Customer.Name, account.CalculateInterest(month));
            }
        }
    }
}

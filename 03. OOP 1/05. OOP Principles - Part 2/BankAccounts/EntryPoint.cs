namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    using BankAccounts.Classes;
    using BankAccounts.Classes.Customer;
    using BankAccounts.Classes.Accounts.Interfaces;
    using BankAccounts.Classes.Accounts;
    public class EntryPoint
    {
        public static void Main()
        {
            CompanyCustomer company = new CompanyCustomer("Company");
            IndividualCustomer pesho = new IndividualCustomer("Pesho");
            IndividualCustomer ivan = new IndividualCustomer("Ivan");
            IAccount peshoLoan = new Loan(pesho, 2500, 6.5m);
            IAccount companyMortgage = new Mortgage(company, 15000, 8.8m);
            IAccount ivanDeposit = new Deposit(ivan, 8000, 3.5m);
            List<IAccount> myAccounts = new List<IAccount>{peshoLoan, companyMortgage, ivanDeposit};
            Bank bigBank = new Bank(myAccounts);
            Console.WriteLine();
            bigBank.ListAllAccounts();
            Console.WriteLine();
            bigBank.InterestForAll(12);
            Console.WriteLine("\nPesho's interest for 30 months: {0}", peshoLoan.CalculateInterest(30));
            Console.WriteLine();

        }
    }
}

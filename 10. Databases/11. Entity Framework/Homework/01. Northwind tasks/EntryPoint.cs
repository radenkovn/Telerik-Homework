namespace _01.Northwind_tasks
{
    using System;

    class EntryPoint
    {
        public static void Main()
        {
            //Commentate if you are reexecuting the program a few times, otherwise it will explode :)

            //Task 2
            CustomersDAO.InsertCustomers("HELLO", "TestCompany");
            CustomersDAO.PrintCustomers("HELLO");

            CustomersDAO.ModifyCustomer("HELLO", "New Company Name");
            CustomersDAO.PrintCustomers("HELLO");

            CustomersDAO.DeleteCustomer("HELLO");
            CustomersDAO.PrintCustomers("HELLO");

            //CustomersDAO.PrintCustomers();
            Console.WriteLine();

            //Task 3
            CustomersDAO.FindAllCanadaNinetySeven();

            //Task 4
            CustomersDAO.FindAllCanadaNinetySevenNative();

            //Task 5
            CustomersDAO.FindAllSales("RJ", new DateTime(1996, 01, 01), new DateTime(1998, 1, 1));

            //Tasks 6-7
            CustomersDAO.TestSaveChanges();

        }


    }
}

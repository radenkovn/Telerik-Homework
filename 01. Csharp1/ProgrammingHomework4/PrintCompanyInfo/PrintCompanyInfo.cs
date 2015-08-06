//PROBLEM 2

using System;


class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter the company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter the company's address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter the company's phone: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Enter the company's FAX: ");
        string companyFax = Console.ReadLine();
        Console.Write("Enter the company's website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter the manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter the manager's second name: ");
        string secondName = Console.ReadLine();
        Console.Write("Enter the manager's age: ");
        string age = Console.ReadLine();
        Console.Write("Enter the manager's phone: ");
        string managerPhone = Console.ReadLine();

        if (companyName == "")
        {
            Console.WriteLine("(no company name)");
        }
        else 
        {
            Console.WriteLine("The company name is: {0}", companyName);
        }


        if (companyAddress == "")
        {
            Console.WriteLine("(no company address)");
        }
        else
        {
            Console.WriteLine("The company address is: {0}", companyAddress);
        }

        if (companyPhone == "")
        {
            Console.WriteLine("(no company phone)");
        }
        else
        {
            Console.WriteLine("The company phone is: {0}", companyPhone);
        }

        if (companyFax == "")
        {
            Console.WriteLine("(no company fax)");
        }
        else
        {
            Console.WriteLine("The company name is: {0}", companyFax);
        }

        if (companyWebsite == "")
        {
            Console.WriteLine("(no company website)");
        }
        else
        {
            Console.WriteLine("Website: {0}", companyWebsite);
        }

        if (firstName == "")
        {
            Console.Write("(no manager first name)");
        }
        else
        {
            Console.Write("Manager: {0}", firstName);
        }

        if (secondName == "")
        {
            Console.Write(" (no manager second name) ");
        }
        else
        {
            Console.Write(" {0} ", secondName);
        }

        if (age == "")
        {
            Console.Write("(no manager age)");
        }
        else
        {
            Console.Write("(age: {0}", age);
        }

        if (managerPhone == "")
        {
            Console.WriteLine("(no manager phone))");
        }
        else
        {
            Console.WriteLine(", tel. {0})", managerPhone);
        }

    }
}
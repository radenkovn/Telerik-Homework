//PROBLEM 10

/*77 4D M
 * 70 46 F
 * 102 66 f
 * 109 6D m*/

using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter employee's FIRST NAME: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter employee's LAST NAME: ");
        string lastName = Console.ReadLine();

        byte age;
        do
        {
            Console.Write("Enter employee's AGE: ");
            age = byte.Parse(Console.ReadLine());
        }
        while (age > 100);

        char gender;
        do
        {
            Console.Write("Enter employee's GENDER: ");
           gender = char.Parse(Console.ReadLine());
        }
        while (gender != 'M' && gender != 'F' && gender != 'f' && gender != 'm');

        Console.Write("Enter employee's ID NUMBER: ");
        long idNUmber = long.Parse(Console.ReadLine());

        Console.Write("Enter employee's EMPLOYEE NUMBER: ");
        int employeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe employee's First Name is {0}.\nThe employee's Last Name is {1}.\nThe employee's Age is {2}.\nThe employee's" +
            " gender is {3}.\nThe employee's ID Number is {4}.\nThe employee's Employee Number is {5}.", firstName, lastName, age, gender, idNUmber, employeeNumber);
    }
}


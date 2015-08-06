//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.


using System;
class Leap
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool leap = DateTime.IsLeapYear(year);
        if (leap)
        {
            Console.WriteLine("The year you entered is leap.");
        }
        else
        {
            Console.WriteLine("The year you entered is not leap!");
        }
    }
}


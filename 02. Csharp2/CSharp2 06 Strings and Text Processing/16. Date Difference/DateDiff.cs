//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;
using System.Globalization;
using System.Threading;
class DateDiff
{
    static void Main()
    {
        string format = "d.MM.yyyy";
        Console.WriteLine("The current format is {0}", format);
        Console.WriteLine("Enter the first date: ");
        string first = Console.ReadLine();
        Console.WriteLine("Enter the second date: ");
        string second = Console.ReadLine();
        
        CultureInfo provider = CultureInfo.InvariantCulture;
        try
        {
            DateTime now = DateTime.ParseExact(first, format, provider);
            DateTime future = DateTime.ParseExact(second, format, provider);
            TimeSpan span = future.Subtract(now);
            Console.WriteLine("The difference between these two dates is {0} days.",span.Days);
        }
        catch (FormatException)
        {
            Console.WriteLine("You have entered invalid dates.");
        } 
    }
}


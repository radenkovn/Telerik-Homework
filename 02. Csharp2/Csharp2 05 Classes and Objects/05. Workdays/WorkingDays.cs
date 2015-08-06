
//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.



using System;
using System.Globalization;
using System.Threading;


class WorkingDays
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime today = DateTime.Now;
        Console.Write("Enter a date in the following format mm/dd/yyyy: ");
        DateTime future = DateTime.Parse(Console.ReadLine());
        TimeSpan span = future.Subtract(today);
        int difference = span.Days;
        int counter = difference;
        DateTime[] holidays = new DateTime[5];
        holidays[0] = DateTime.Parse("03/03");//Natinal Holyday
        holidays[1] = DateTime.Parse("12/25");//Christmas
        holidays[2] = DateTime.Parse("01/01");//New Year
        holidays[3] = DateTime.Parse("11/01");//Den na buditelite
        holidays[4] = DateTime.Parse("12/24");//Christmas Eve

        for (int i = 1; i <= difference; i++)
        {
            DateTime checker = DateTime.Now.AddDays(i);
            if (checker.DayOfWeek == DayOfWeek.Saturday || checker.DayOfWeek == DayOfWeek.Sunday)
            {
                counter--;
            }
            else
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (holidays[j].Month == checker.Month && holidays[j].Day == checker.Day)
                    {
                        counter--;
                    }
                }
            }
        }
        Console.WriteLine("The workdays between {0:d MMMM yyyy} and {1:d MMMM yyyy} are {2}.", today, future, counter);
    }
}


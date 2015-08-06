//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the
//date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;
class BGDate
{
    static void Main()
    {
        Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;
        string format = "d.MM.yyyy H:m:s";
        Console.WriteLine("The current format is {0}", format);
        Console.WriteLine("Enter the date: ");
        string date = Console.ReadLine();
        CultureInfo provider = CultureInfo.InvariantCulture;

        try
        {
            DateTime now = DateTime.ParseExact(date, format, provider);
            DateTime future = now.AddHours(6.5);
            string day;
            switch (future.DayOfWeek)
            {
                case DayOfWeek.Friday: day = "Петък";
                    break;
                case DayOfWeek.Monday: day = "Понеделник";
                    break;
                case DayOfWeek.Saturday: day = "Вторник";
                    break;
                case DayOfWeek.Sunday: day = "Сряда";
                    break;
                case DayOfWeek.Thursday: day = "Петък";
                    break;
                case DayOfWeek.Tuesday: day = "Събота";
                    break;
                case DayOfWeek.Wednesday: day = "Неделя";
                    break;
                default: day = "";
                    break;
            }
            Console.WriteLine("{0:d.MM.yyyy HH:m:ss} {1}", future, day);
        }
        catch (FormatException)
        {
            Console.WriteLine("You have entered an invalid dates.");
            return;
        }
    }

}


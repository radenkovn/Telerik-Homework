//PROBLEM 10

using System;
using System.Globalization;


class BeerTime
{
    static void Main()
    {
        string newDate = Console.ReadLine();
        string format = "hh:mm tt";
        CultureInfo provider = CultureInfo.InvariantCulture;
        DateTime result;
        try
        {
            result = DateTime.ParseExact(newDate, format, provider);
            bool beerTime = 13 <= result.Hour || (0 <= result.Hour && result.Hour < 3);
            if (beerTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid time (the format is: 01:01 PM)");
        } 
    }
}

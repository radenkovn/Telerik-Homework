using System;

class FutureAge
{
    static void Main()
    {
        Console.Write("Enter the YEAR you were born in and press enter: ");
        int birthYear = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the number of the MONTH you were born in and press enter: ");
        int birthMonth = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the DAY you were born on and press enter: ");
        int birthDay = Int32.Parse(Console.ReadLine());

        DateTime birthTime = new DateTime(birthYear, birthMonth, birthDay);
        DateTime currentYear = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        int currentAge;
        if (currentYear.Month > birthTime.Month)
        {
            currentAge = currentYear.Year - birthTime.Year;
        }
        else if (currentYear.Month < birthTime.Month)
        {
            currentAge = currentYear.Year - birthTime.Year - 1;
        }
        else
        {
            if (currentYear.Day >= birthTime.Day)
            {
                currentAge = currentYear.Year - birthTime.Year;
            }
            else
            {
                currentAge = currentYear.Year - birthTime.Year - 1;
            }
        }
        Console.WriteLine("You are currently " + currentAge + " years old.");
        Console.WriteLine("In ten years, you will be " + (currentAge + 10) + " years old.");
    }
}


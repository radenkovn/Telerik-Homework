namespace RangeExceptions
{
    using System;
    using System.Globalization;

    using RangeExceptions.Classes;

    class AppStart
    {
        static void Main()
        {
            try
            {
                TryInts(0, 100);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            DateTime dateStart = new DateTime(1980, 1, 1);
            DateTime dateEnd = new DateTime(2013, 12, 31);
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                TryDate(dateStart, dateEnd);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            //   1.1.1980 … 31.12.2013
        }
        static void TryInts(int start, int end)
        {
            Console.Write("Enter an int <{0} or >{1}: ", start, end);

            int testInt = int.Parse(Console.ReadLine());
            if (testInt < start || testInt > end)
            {
                throw new InvalidRangeException<int>(start, 100);
            }
        }
        static void TryDate(DateTime dateStart, DateTime dateEnd)
        {
            string format = "d.MM.yyyy";
            Console.WriteLine("The current format is {0}", format);
            Console.WriteLine("Enter a date between {0} and {1}", dateStart, dateEnd);
            CultureInfo provider = CultureInfo.InvariantCulture;

            try
            {
                DateTime now = DateTime.ParseExact(Console.ReadLine(), format, provider);
                if (now.CompareTo(dateStart) < 0 || now.CompareTo(dateEnd) > 0)
                {
                    throw new InvalidRangeException<DateTime>(dateStart, dateEnd);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered an invalid date.");
            }
        }
    }
}

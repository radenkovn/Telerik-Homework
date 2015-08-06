
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.


using System;
using System.Globalization;
using System.Text.RegularExpressions;
class CanadaDate
{

    static void Main(string[] args)
    {
        //Enter whatever format you want!
        string testDate = "Contact Telerik at 15.03.2012 or 16.02.2002";

        Console.WriteLine("Method one:\n");
        DateToCanadaOne(testDate);

        Console.WriteLine("\nMethod two:\n");
        DateToCanadaTwo(testDate);

        Console.WriteLine();

    }

    private static void DateToCanadaTwo(string testDate)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string format = "dd.MM.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
        char[] checker = testDate.ToCharArray();
        for (int i = 2; i < checker.Length - 7; i++)
        {
            int day = -1;
            int month = -1;
            int year = -1;
            bool currentPoint = (checker[i] == '.');
            bool aftertwoPoint = (checker[i + 3] == '.');
            if (currentPoint && aftertwoPoint)
            {

                bool previousTwoIsNumber = ('0' <= checker[i - 2] && checker[i - 2] < '9');
                bool previousOneIsNumber = ('0' <= checker[i - 1] && checker[i - 1] < '9');
                if (previousOneIsNumber && previousTwoIsNumber)
                {
                    day = (checker[i - 2] - '0') * 10 + (checker[i - 1] - '0');
                }


                bool currentOneIsNumber = ('0' <= checker[i + 1] && checker[i + 1] < '9');
                bool currentTwoIsNumber = ('0' <= checker[i + 2] && checker[i + 2] < '9');
                if (currentOneIsNumber && currentTwoIsNumber)
                {
                    month = (checker[i + 1] - '0') * 10 + (checker[i + 2] - '0');
                }
                bool nextOneIsNumber = ('0' <= checker[i + 4] && checker[i + 4] < '9');
                bool nextTwoIsNumber = ('0' <= checker[i + 5] && checker[i + 5] < '9');
                bool nextThreeIsNumber = ('0' <= checker[i + 6] && checker[i + 6] < '9');
                bool nextFourIsNumber = ('0' <= checker[i + 7] && checker[i + 7] < '9');
                if (nextOneIsNumber && nextTwoIsNumber && nextThreeIsNumber && nextFourIsNumber)
                {
                    year = (checker[i + 4] - '0') * 1000 + (checker[i + 5] - '0') * 100 + (checker[i + 6] - '0') * 10 + (checker[i + 7] - '0');
                }
                if (day > 0 && month > 0 && year > 0)
                {
                    string date = Convert.ToString(day).PadLeft(2, '0') + "." + Convert.ToString(month).PadLeft(2, '0') + "." + Convert.ToString(year).PadLeft(4, '0');
                    //Console.WriteLine(date);
                    try
                    {
                        DateTime now = DateTime.ParseExact(date, format, provider);
                        Console.WriteLine(date);
                    }
                    catch (FormatException)
                    {
                        //Console.WriteLine(false);
                        continue;
                    }
                }
            }
        }
    }

    private static void DateToCanadaOne(string testDate)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        string format = "dd.MM.yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
        Regex rgx = new Regex(@"\d{2}\W\d{2}\W\d{4}");
        int index = testDate.IndexOf(".") - 2;
        while (index >= 0)
        {
            if (index >= 0)
            {
                Match mat = rgx.Match(testDate, index - 2);
                if (mat.Equals(string.Empty) == false)
                {
                    string date = mat.ToString();
                    try
                    {
                        DateTime now = DateTime.ParseExact(date, format, provider);
                        Console.WriteLine(date);
                    }
                    catch (FormatException)
                    {
                    }
                    index = testDate.IndexOf(".", (testDate.IndexOf(mat.ToString()) + 7));

                }
                if (index >= 0 && index < testDate.Length - 7)
                {
                    index = testDate.IndexOf(".", index + 7);
                }
                else
                {
                    index = -1;
                }
            }
        }
    }
}



//PROBLEM 11

using System;
using System.Globalization;
class NumbersAsWords
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("Zero");
        }
        else
        {
            int digit;
            int numberLength = 0;
            int numberCheck = number;
            string tierOne = "";
            string tierTwo = "";
            string tierThree = "";
            string output;
            do
            {
                numberCheck /= 10;
                numberLength++;
            }
            while (numberCheck > 0);
            numberCheck = number;
            for (int i = 0; i < numberLength; i++)
            {
                digit = numberCheck % 10;
                numberCheck /= 10;
                if (i == 0)
                {
                    if ((number / 10) % 10 == 1)
                    {
                        digit = number % 10;
                        switch (digit)
                        {

                            case 0: { tierOne += "ten"; break; }
                            case 1: { tierOne += "eleven"; break; }
                            case 2: { tierOne += "twelve"; break; }
                            case 3: { tierOne += "thirteen"; break; }
                            case 4: { tierOne += "fourteen"; break; }
                            case 5: { tierOne += "fifteen"; break; }
                            case 6: { tierOne += "sixteen"; break; }
                            case 7: { tierOne += "seventeen"; break; }
                            case 8: { tierOne += "eighteen"; break; }
                            case 9: { tierOne += "nineteen"; break; }
                            default: break;
                        }

                    }
                    else
                    {
                        switch (digit)
                        {

                            case 0: { tierOne += ""; break; }
                            case 1: { tierOne += "one"; break; }
                            case 2: { tierOne += "two"; break; }
                            case 3: { tierOne += "three"; break; }
                            case 4: { tierOne += "four"; break; }
                            case 5: { tierOne += "five"; break; }
                            case 6: { tierOne += "six"; break; }
                            case 7: { tierOne += "seven"; break; }
                            case 8: { tierOne += "eight"; break; }
                            case 9: { tierOne += "nine"; break; }
                            default: break;
                        }
                    }
                }
                else if (i == 1)
                {
                    switch (digit)
                    {
                        case 0: { tierTwo += ""; break; }
                        case 1: { tierTwo += ""; break; }
                        case 2: { tierTwo += "twenty"; break; }
                        case 3: { tierTwo += "thirty"; break; }
                        case 4: { tierTwo += "fourty"; break; }
                        case 5: { tierTwo += "fifty"; break; }
                        case 6: { tierTwo += "sixty"; break; }
                        case 7: { tierTwo += "seventy"; break; }
                        case 8: { tierTwo += "eighty"; break; }
                        case 9: { tierTwo += "ninety"; break; }
                        default: break;
                    }
                }
                else if (i == 2)
                {
                    switch (digit)
                    {
                        case 1: { tierThree += "one hundred"; break; }
                        case 2: { tierThree += "two hundred"; break; }
                        case 3: { tierThree += "three hundred"; break; }
                        case 4: { tierThree += "four hundred"; break; }
                        case 5: { tierThree += "five hundred"; break; }
                        case 6: { tierThree += "six hundred"; break; }
                        case 7: { tierThree += "seven hundred"; break; }
                        case 8: { tierThree += "eight hundred"; break; }
                        case 9: { tierThree += "nine hundred"; break; }
                        default: break;
                    }
                }
            }
            if (number % 100 == 0 || numberLength == 1)
            {
                output = tierThree + tierTwo + tierOne;
            }
            else if ((number % 10 == 0 && numberLength == 3) || (((number / 10) % 10 == 1) && (numberLength == 3)) || (number / 10) % 10 == 0)
            {
                output = tierThree + " and " + tierTwo + tierOne;
            }
            else if (numberLength == 3)
            {
                output = tierThree + " and " + tierTwo + " " + tierOne;
            }
            else if (numberLength == 2 && number > 19)
            {
                output = tierThree + tierTwo + " " + tierOne;
            }
            else
            {
                output = tierThree + tierTwo + tierOne;
            }
           Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(output.ToLower()));
            }
    }
}


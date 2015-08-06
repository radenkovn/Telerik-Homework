//    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9



using System;
using System.Linq;
class SubStr
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();
        Console.Write("Enter your substring: ");
        string subStr = Console.ReadLine();
        int count = TimesInStr(input, subStr);
        Console.WriteLine(count);
    }
    // We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    private static int TimesInStr(string input, string subStr)
    {
        int counter = 0;
        int index = input.IndexOf(subStr);
        while (index >= 0)
        {
            index = input.IndexOf(subStr, index + 1, StringComparison.OrdinalIgnoreCase);
            counter++;
        }
        return counter;
    }


}


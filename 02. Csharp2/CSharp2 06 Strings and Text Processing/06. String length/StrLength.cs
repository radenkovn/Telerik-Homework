//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.


using System;
using System.Text;
class StrLength
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();
        LengthTwenty(input);
    }

    private static void LengthTwenty(string input)
    {
        StringBuilder builder = new StringBuilder(input);
        if (builder.Length < 20)
        {
            builder.Append('*', 20 - builder.Length);
        }
        Console.WriteLine(builder);
    }
}


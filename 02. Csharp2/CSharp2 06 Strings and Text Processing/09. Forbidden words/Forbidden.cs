//    We are given a string containing a list of forbidden words and a text containing some of these words.
//    Write a program that replaces the forbidden words with asterisks.

//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***

using System;
using System.Text;
class Forbidden
{
    static void Main()
    {
        Console.Write("Enter your string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Enter the forbidden words, separated by spaces: ");
        string[] forbidden = Console.ReadLine().Split(' ');
        ForbiddenFixed(input, forbidden);
    }

    private static void ForbiddenFixed(string input, string[] forbidden)
    {
        StringBuilder result = new StringBuilder(input);
        for (int i = 0; i < forbidden.Length; i++)
        {
            for (int j = 0; j < result.Length; j++)
            {
                int index = input.IndexOf(forbidden[i]);
                if (index > 0)
                {
                    for (int k = 0; k < forbidden[i].Length; k++)
                    {
                        result[index + k] = '*';
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}

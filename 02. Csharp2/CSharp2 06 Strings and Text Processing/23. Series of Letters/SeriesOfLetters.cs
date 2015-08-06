//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.

using System;
using System.Text;
class SeriesOfLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine(LetterSeries(text));

    }

    private static StringBuilder LetterSeries(string text)
    {
        StringBuilder result = new StringBuilder();
        char[] arrText = text.ToCharArray();
        for (int i = 0; i < arrText.Length; i++)
        {
            int count = 0;
            char current = char.ToLower(arrText[i]);
            for (int j = i; j < arrText.Length; j++)
            {
                if (current != arrText[j])
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            i = i + count - 1;
            result.Append(current);  
        }
        return result;
    }
}


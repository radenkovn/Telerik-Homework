//    You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//    The tags cannot be nested.
//Example: We are living in a <upcase><upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase></upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;
class ParseTags
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string input = Console.ReadLine();
        TagParse(input);
    }

    private static void TagParse(string text)
    {
        int indexStart = text.IndexOf("<upcase>");
        int indexEnd = text.IndexOf("</upcase>");
        char[] textStr = text.ToCharArray();
        while (indexStart >= 0)
        {
            for (int i = indexStart + 7; i < indexEnd; i++)
            {
                textStr[i] = Char.ToUpper(textStr[i]);
            }
            indexStart = text.IndexOf("<upcase>", indexStart + 1);
            indexEnd = text.IndexOf("</upcase>", indexEnd + 1);

        }
        StringBuilder builder = new StringBuilder();
        string result = string.Join("", textStr);
        indexStart = result.IndexOf("<upcase>");
        indexEnd = result.IndexOf("</upcase>");
        if (indexStart >= 0)
        {
            builder.Append(result.Substring(0, indexStart));
        }
        while (indexStart >= 0)
        {
            builder.Append(result.Substring(indexStart + 8, indexEnd - indexStart - 8));
            indexStart = result.IndexOf("<upcase>", indexStart + 1);
            if (indexStart >= 0)
            {
                builder.Append(result.Substring(indexEnd + 9, indexStart - indexEnd - 9));
                indexEnd = result.IndexOf("</upcase>", indexEnd + 1);
            }
        }
        builder.Append(result.Substring(indexEnd + 9));
        Console.WriteLine(builder);
    }
}


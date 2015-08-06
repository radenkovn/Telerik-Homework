//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Text;
class ExtractEmail
{
    static void Main()
    {
        string text = "Most of mobile carriers offer free Email 1234567890@message.alltel.com To SMS gateways which can be used to forward simple text " +
                        "emails to a mobile 1234567890@tmomail.net. phones. And the good news, majority of " +
                        "those gateways are. 1234567890@email.uscc.net free and available to the general public.";
        Console.WriteLine("Extracted emails:");
        EmailExtraction(text);




    }

    private static void EmailExtraction(string text)
    {
        int firstIndex = 0;
        int lastSpace = 0;
        int nextSpace = 0;
        StringBuilder result = new StringBuilder();
        while (firstIndex >= 0)
        {

            firstIndex = text.IndexOf("@", firstIndex);
            if (firstIndex >= 0)
            {
                lastSpace = text.LastIndexOf(" ", firstIndex);
                nextSpace = text.IndexOf(" ", firstIndex);
                result.Append(text.Substring(lastSpace + 1, nextSpace - lastSpace));
                if (result[result.Length - 2] == '.' || result[result.Length - 2] == '!' || result[result.Length - 2] == '?' || result[result.Length - 2] == ',')
                {
                    result.Remove(result.Length - 2, 1);
                }
                firstIndex++;
            }
        }
        Console.WriteLine(result);
    }
}


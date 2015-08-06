//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

using System;
using System.Text;
class LetterCount
{
    static void Main()
    {
        string text = "Most of mobile carriers offer free Email 1234567890@message.alltel.com To SMS gateways which can be used to forward simple text " +
                        "emails to a mobile 1234567890@tmomail.net. phones. And the good news, majority of " +
                        "those gateways are. 1234567890@email.uscc.net free and available to the general public.";
        LetterCounter(text);

    }

    private static void LetterCounter(string text)
    {
        char[] arrText = text.ToCharArray();
        for (int i = 0; i < arrText.Length; i++)
        {
            char current = char.ToLower(arrText[i]);
            int count = 0;
            if (('a' <= current && current <= 'z') || ('A' <= current && current <= 'Z'))
            {

                for (int j = i; j < arrText.Length; j++)
                {

                    if (('a' <= current && current <= 'z') || ('A' <= current && current <= 'Z'))
                    {

                        if (char.ToLower(current) == char.ToLower(arrText[j]))
                        {
                            count++;
                            arrText[j] = '0';
                        }
                    }
                }
                Console.WriteLine("{0} is {1,2} times inside the text", current, count);
            }

        }
    }
}


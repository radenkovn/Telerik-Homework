//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
class WordCounter
{
    static void Main()
    {
        string text = "Most of mobile carriers offer free Email 1234567890@message.alltel.com To SMS gateways which can be used to forward simple text emails to a mobile 1234567890@tmomail.net. phones. And the good news, majority of those gateways are. 1234567890@email.uscc.net free and available to the general public.";
        WordCount(text);

    }

    private static void WordCount(string text)
    {

        string[] checker = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(checker);
        for (int i = 0; i < checker.Length; i++)
        {
            string current = checker[i];
            int count = 0;
            for (int j = i; j < checker.Length; j++)
            {
                if (current != checker[j])
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            i = i + count - 1;
            Console.WriteLine("{0,30} is present {1,2} times inside the text", current, count);


        }
    }
}


//  Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
class Order
{
    static void Main()
    {
        string text = "Most of mobile carriers offer free Email 1234567890@message.alltel.com To SMS gateways which can be used to forward simple text " +
                "emails to a mobile 1234567890@tmomail.net phones And the good news majority of " +
                "those gateways are 1234567890@email.uscc.net free and available to the general public";
        WordOrder(text);
    }

    private static void WordOrder(string text)
    {
        string[] checker = text.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(checker);
        foreach (string str in checker)
        {
            Console.WriteLine(str);
        }
    }
}


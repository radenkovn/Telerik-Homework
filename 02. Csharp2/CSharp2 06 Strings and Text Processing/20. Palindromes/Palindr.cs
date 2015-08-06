//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.


using System;
class Palindr
{
    static void Main()
    {
        string input = "Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.";
        Console.WriteLine(input);
        Console.WriteLine();
        Console.WriteLine("The palindromes in your text are:");
        PrintPalindromes(input);
        Console.WriteLine();
    }


    static void PrintPalindromes(string myString)
    {
        string[] checker = myString.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string str in checker)
        {
            if (str.Length > 2)
            {
                string first = str.Substring(0, str.Length / 2);
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                string temp = new string(arr);
                string second = temp.Substring(0, temp.Length / 2);
                if (first.Equals(second) == true)
                {
                    Console.WriteLine(str);
                }
            }
        }

    }



}


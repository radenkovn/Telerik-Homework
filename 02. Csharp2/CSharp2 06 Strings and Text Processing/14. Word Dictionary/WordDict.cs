//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.


using System;
class WordDict
{
    static void Main()
    {

        Console.WriteLine("Enter the word: ");
        string input = Console.ReadLine();
        Console.WriteLine(DictSearch(input));
    }

    private static string DictSearch(string input)
    {
        const int length = 3;
        string[,] dictionary = new string[2, length]{
                                  { ".NET", "CLR", "namespace" },
                                  {"platform for applications from Microsoft", "managed execution environment for .NET", "hierarchical organization of classes" }};
        for (int i = 0; i < length; i++)
        {
            if (input.ToLower() == dictionary[0, i].ToLower())
            {
                return dictionary[1, i];
            }
        }
        return "The word is not in the dictionary";
    }
}


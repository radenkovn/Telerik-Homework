

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.



using System;
class IndexLetters
{
    static void Main()
    {
        string alphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Console.Write("Enter words consisting only of capital letters: ");
        char[] alphabetArray = alphabetString.ToCharArray();
        string readWord = Console.ReadLine();
        for (int i = 0; i < readWord.Length; i++)
        {
            for (int j = 0; j < alphabetArray.Length; j++)
            {
                if (readWord[i] == alphabetArray[j])
                {
                    Console.WriteLine("The index of {0} is {1}.", readWord[i], j + 1);
                }
            }
        }
    }
}


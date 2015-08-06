//Write a program that compares two char arrays lexicographically (letter by letter).


using System;


class CharArrays
{
    static void Main()
    {
        string firstString = Console.ReadLine();
        string secondString = Console.ReadLine();
        char[] firstChar = firstString.ToCharArray();
        char[] secondChar = secondString.ToCharArray();
        bool checkIfSame = true;
        if (firstChar.Length != secondChar.Length)
        {
            checkIfSame = false;
        }
        else
        {
            for (int i = 0; i < firstChar.Length; i++)
            {
                if (firstChar[i] != secondChar[i])
                {
                    checkIfSame = false;
                }
            }
        }
        Console.WriteLine(checkIfSame);
    }
}


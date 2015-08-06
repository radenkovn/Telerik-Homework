//Problem 6

using System;

class StringsObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object interestingObject = firstString + secondString;
        string thirdString = (string)interestingObject;
        Console.WriteLine(firstString + "\n" + secondString + "\n" + interestingObject + "\n" + thirdString);
    }
}


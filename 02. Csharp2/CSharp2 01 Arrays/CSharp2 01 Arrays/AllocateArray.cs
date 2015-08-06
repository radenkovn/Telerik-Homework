//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int[] twentyNumbers = new int[20];
        for (int i = 0; i < twentyNumbers.Length; i++)
        {
            twentyNumbers[i] = i * 5;
        }
        string printed = string.Join(", ", twentyNumbers);
        Console.WriteLine(printed);
    }
}


//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class StringReverse
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string normal = Console.ReadLine();
        string reversed = ReverseStr(normal);
        Console.WriteLine("The reverse string is {0}", reversed);
    }

    static string ReverseStr(string normal)
    {
        char[] normalArr = normal.ToCharArray();
        Array.Reverse(normalArr);
        string reversed = new string(normalArr);
        return reversed;
    }

}


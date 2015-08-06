//Write a program that reverses the words in given sentence.

using System;
using System.Text;
class Reverse
{
    static void Main()
    {
        Console.WriteLine("Enter your sentence:");
        string normal = Console.ReadLine();
        char end = normal[normal.Length - 1];
        string normalWithoutEnd = normal.Substring(0, normal.Length - 1);
        string[] checker = normalWithoutEnd.Split(' ');
        string[] reversedStr = normalWithoutEnd.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(reversedStr);
        string reversed = (string.Join(" ", reversedStr) + end);
        StringBuilder builder = new StringBuilder(reversed);
        
        Console.WriteLine(reversed);

    }
}


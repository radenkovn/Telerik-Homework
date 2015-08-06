//    Write a program that converts a string to a sequence of C# Unicode character literals.
//    Use format strings.

//Example:
//input 	output
//Hi! 	\u0048\u0069\u0021

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your string here: ");
        string text = Console.ReadLine();
        char[] textArr = text.ToCharArray();
        for (int i = 0; i < textArr.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)textArr[i]);
        }
        Console.WriteLine();
    }
}


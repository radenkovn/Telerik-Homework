//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.


using System;
class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter your number here: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("As decimal:     {0,15 :D}", number);
        Console.WriteLine("As hexadecimal: {0,15 :X}", number);
        Console.WriteLine("As percentage:  {0,15 :P}", number);
    }
}


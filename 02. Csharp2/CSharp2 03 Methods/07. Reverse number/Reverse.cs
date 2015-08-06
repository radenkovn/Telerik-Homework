//Write a method that reverses the digits of given decimal number.

//  input 	    output
//  256 	    652
//  123.45 	    54.321
using System;
class Reverse
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        decimal reversed = ReverseNumber(number);
        Console.WriteLine("The reversed number is: {0}", reversed);
    }

    static decimal ReverseNumber(decimal number)
    {
        bool negative = false;
        if (number < 0)
        {
            negative = true;
            number *= -1;
        }
        char[] numberAsArr = (number.ToString()).ToCharArray();
        Array.Reverse(numberAsArr);
        string reversedString = "";
        if (negative)
        {
            reversedString += "-" + string.Join("", numberAsArr);
        }
        else
        {
            reversedString += string.Join("", numberAsArr);
        }
        return decimal.Parse(reversedString);
    }

}


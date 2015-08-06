//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

//binary 	                    decimal
//0 	                        0
//11 	                        3
//1010101010101011 	            43691
//1110000110000101100101000000 	236476736

using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        long realNumber = 0;
        long currentDigit;
        char[] numbers = binary.ToCharArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == '1')
            {
                currentDigit = 1;
            }
            else
            {
                currentDigit = 0;

            }
            realNumber += currentDigit * (long)Math.Pow(2, numbers.Length - i - 1);
        }
        Console.WriteLine(realNumber);
    }
}

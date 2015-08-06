//Write a program to convert binary numbers to their decimal representation.

using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        if (binary == "0")
        {
            Console.WriteLine(0);
        }
        else
        {
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
}
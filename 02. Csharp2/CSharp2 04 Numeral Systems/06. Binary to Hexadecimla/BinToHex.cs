
//Write a program to convert binary numbers to hexadecimal numbers (directly).


using System;
class BinToHex
{
    static void Main()
    {
        string hex = Console.ReadLine();
        string realNumber = "";

        int remainder = hex.Length % 4;
        string converted = new string('0', 4 - remainder) + hex;
        char[] numbers = converted.ToCharArray();
        for (int i = 0; i < numbers.Length - 3; i += 4)
        {

            string currentDigit = "";
            string currentChecker = numbers[i].ToString() + numbers[i + 1].ToString() + numbers[i + 2].ToString() + numbers[i + 3].ToString();
            switch (currentChecker)
            {
                case "0001": currentDigit += '1'; break;
                case "0010": currentDigit += '2'; break;
                case "0011": currentDigit += '3'; break;
                case "0100": currentDigit += '4'; break;
                case "0101": currentDigit += '5'; break;
                case "0110": currentDigit += '6'; break;
                case "0111": currentDigit += '7'; break;
                case "1000": currentDigit += '8'; break;
                case "1001": currentDigit += '9'; break;
                case "1010": currentDigit += 'A'; break;
                case "1011": currentDigit += 'B'; break;
                case "1100": currentDigit += 'C'; break;
                case "1101": currentDigit += 'D'; break;
                case "1110": currentDigit += 'E'; break;
                case "1111": currentDigit += 'F'; break;
                case "0000": currentDigit += '0'; break;
                default: break;
            }
            realNumber += currentDigit;
        }
        Console.WriteLine("The number is {0}", realNumber);
    }
}

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
class HexToBin
{
    static void Main()
    {
        string hex = Console.ReadLine();
        string realNumber = "";
        char[] numbers = hex.ToCharArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            string currentDigit = "";
            switch (numbers[i])
            {
                case '1': currentDigit += "0001"; break;
                case '2': currentDigit += "0010"; break;
                case '3': currentDigit += "0011"; break;
                case '4': currentDigit += "0100"; break;
                case '5': currentDigit += "0101"; break;
                case '6': currentDigit += "0110"; break;
                case '7': currentDigit += "0111"; break;
                case '8': currentDigit += "1000"; break;
                case '9': currentDigit += "1001"; break;
                case 'A': currentDigit += "1010"; break;
                case 'B': currentDigit += "1011"; break;
                case 'C': currentDigit += "1100"; break;
                case 'D': currentDigit += "1101"; break;
                case 'E': currentDigit += "1110"; break;
                case 'F': currentDigit += "1111"; break;
                case '0': currentDigit += "0000"; break;
                default: break;
            }
            realNumber += currentDigit;
        }
        long numberer = long.Parse(realNumber);
        Console.WriteLine("The number is {0}", numberer);
    }
}

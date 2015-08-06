//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

//hexadecimal 	decimal
//FE 	        254
//1AE3 	        6883
//4ED528CBB4 	338583669684


using System;
class HexToDec
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long realNumber = 0;
        long currentDigit = 0;
        char[] numbers = hex.ToCharArray();
        for (int i = 0; i < numbers.Length; i++)
        {
            switch (numbers[i])
            {
                case '1': currentDigit = 1; break;
                case '2': currentDigit = 2; break;
                case '3': currentDigit = 3; break;
                case '4': currentDigit = 4; break;
                case '5': currentDigit = 5; break;
                case '6': currentDigit = 6; break;
                case '7': currentDigit = 7; break;
                case '8': currentDigit = 8; break;
                case '9': currentDigit = 9; break;
                case 'A': currentDigit = 10; break;
                case 'B': currentDigit = 11; break;
                case 'C': currentDigit = 12; break;
                case 'D': currentDigit = 13; break;
                case 'E': currentDigit = 14; break;
                case 'F': currentDigit = 15; break;
                case '0': currentDigit = 0; break;
                default: break;
            }
            realNumber += currentDigit * (long)Math.Pow(16, numbers.Length - i - 1);
        }
        Console.WriteLine(realNumber);
    }
}


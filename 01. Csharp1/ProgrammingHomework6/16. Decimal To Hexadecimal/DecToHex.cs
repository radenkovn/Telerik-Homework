//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

//decimal 	    hexadecimal
//254 	        FE
//6883 	        1AE3
//338583669684 	4ED528CBB4


using System;
class DecToHex
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        string reversed = "";
        int digit;
        long changer = number;
        int counter = 0;
        while (changer > 0)
        {
            counter++;
            changer /= 16;
        }
        changer = number;
        for (int i = 0; i < counter; i++)
        {
            digit = (int)(changer % 16);
            switch (digit)
            {
                case 1: reversed += "1"; break;
                case 2: reversed += "2"; break;
                case 3: reversed += "3"; break;
                case 4: reversed += "4"; break;
                case 5: reversed += "5"; break;
                case 6: reversed += "6"; break;
                case 7: reversed += "7"; break;
                case 8: reversed += "8"; break;
                case 9: reversed += "9"; break;
                case 10: reversed += "A"; break;
                case 11: reversed += "B"; break;
                case 12: reversed += "C"; break;
                case 13: reversed += "D"; break;
                case 14: reversed += "E"; break;
                case 15: reversed += "F"; break;
                case 0: reversed += "0"; break;
                default: break;
            }
            changer /= 16;
        }
        char[] normal = reversed.ToCharArray();
        Array.Reverse(normal);
        string realNumber = new string(normal);
        Console.WriteLine(realNumber);
    }
}
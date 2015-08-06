//Write a program to convert decimal numbers to their hexadecimal representation.

using System;
class DecToHex
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine(0);
        }
        else
        {

            string reversed = "";
            int digit;
            long changer = 0;
            if (number < 0)
            {
                changer = number * -1;
            }
            else
            {
                changer = number;
            }
            int counter = 0;

            while (changer > 0)
            {
                counter++;
                changer /= 16;
            }

            if (number < 0)
            {
                changer = number * -1;
            }
            else
            {
                changer = number;
            }
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
            if (number < 0)
            {
                string realNumber = "-" + new string(normal);
                Console.WriteLine(realNumber);
            }
            else
            {
                string realNumber = new string(normal);
                Console.WriteLine(realNumber);
            }
        }
    }
}
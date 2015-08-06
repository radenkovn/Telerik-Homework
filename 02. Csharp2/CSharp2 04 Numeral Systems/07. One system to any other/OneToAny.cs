//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
class OneToAny
{
    static void Main()
    {
        Console.Write("Enter the number you want to conver: ");
        string number = Console.ReadLine();
        Console.Write("Enter the number of the numeral system the number is in: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of the numeral system you wish that it's converted in: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine(ConverToAny(number, first, second));



    }
    static string ConverToAny(string number, int first, int second)
    {
        return DecimalToAny(AnyToDecimal(number, first), second);
    }

    static string DecimalToAny(int number, int system)
    {
        string reversed = "";
        int digit;
        int counter = 0;
        int changer = number;
        while (changer > 0)
        {
            counter++;
            changer /= system;
        }

        changer = number;
        for (int i = 0; i < counter; i++)
        {
            digit = (int)(changer % system);
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
            changer /= system;
        }
        char[] normalBig = reversed.ToCharArray();
        Array.Reverse(normalBig);
        string result = new string(normalBig);
        return result;
    }

    static int AnyToDecimal(string number, int system)
    {
        int realNumber = 0;
        int currentDigit = 0;
        char[] numbers = number.ToCharArray();
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
            realNumber += currentDigit * (int)Math.Pow(system, numbers.Length - i - 1);
        }
        return realNumber;
    }
}


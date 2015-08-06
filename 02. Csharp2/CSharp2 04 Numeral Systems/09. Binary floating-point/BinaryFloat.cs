using System;
class BinaryFloat
{
    static void Main()
    {
        Console.WriteLine("Enter your numeber: ");
        float number = 12.290385f;
        FloatingBinary(number);
    }
    

    private static void FloatingBinary(float number)
    {
        string numberString = number.ToString();
        int pointIndex = numberString.IndexOf(".");
        int eIndex = numberString.IndexOf("E");
        string fractionPart = "0" + numberString.Substring(pointIndex);
        string wholePart = numberString.Substring(0, pointIndex);
        Console.WriteLine(eIndex);
        Console.WriteLine(pointIndex);
        Console.WriteLine(fractionPart);
        Console.WriteLine(wholePart);
        
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
}


//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

//decimal 	            binary
//0 	                0
//3 	                11
//43691 	            1010101010101011
//236476736 	        1110000110000101100101000000


using System;
class DecToBinary
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
            changer /= 2;
        }
        changer = number;
        for (int i = 0; i < counter; i++)
        {
            digit = (int)(changer % 2);
            if (digit == 1)
            {
                reversed += "1";
            }
            else
            {
                reversed += "0";
            }
            changer /= 2;
        }
        char[] normal = reversed.ToCharArray();
        Array.Reverse(normal);
        string realNumber = new string(normal);
        Console.WriteLine(realNumber);
    }
}

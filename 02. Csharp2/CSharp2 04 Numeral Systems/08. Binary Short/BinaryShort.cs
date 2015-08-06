//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
class BinaryShort
{
    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
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
                changer /= 2;
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

            if (number < 0)
            {
                for (int i = 0; i < normal.Length; i++)
                {
                    if (normal[i] == '1')
                    {
                        normal[i] = '0';
                    }
                    else
                    {
                        normal[i] = '1';
                    }
                }
                if (normal[normal.Length - 1] == '0')
                {
                    normal[normal.Length - 1] = '1';
                }
                else
                {
                    int index = normal.Length - 1;
                    while (normal[index] == '1')
                    {
                        normal[index] = '0';
                        index--;
                    }
                    normal[index] = '1';
                }
            }
            if (number > 0)
            {
                string realNumber = new string(normal);
                Console.WriteLine(realNumber);
            }
            else
            {
                string realNumber = new string('1', (16 - normal.Length));
                realNumber += new string(normal);
                Console.WriteLine(realNumber);
            }
        }

    }
}
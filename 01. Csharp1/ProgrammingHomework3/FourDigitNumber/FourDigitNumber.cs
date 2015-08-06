//PROBLEM 6

using System;


class FourDigitNumber
{
    static void Main()
    {
        int fourDigit;
        do
        {
            Console.Write("Enter a FOUR digit number:  ");
            fourDigit = int.Parse(Console.ReadLine());
        }
        while ((fourDigit / 1000 < 1) || (fourDigit / 10000 >= 1));
        int a = (fourDigit / 1000) % 10;
        int b = (fourDigit / 100) % 10;
        int c = (fourDigit / 10) % 10;
        int d = fourDigit % 10;
        int digitSum = a + b + c + d;
        Console.WriteLine("The sum of the digits is {0}", digitSum);
        Console.WriteLine("The reverse number is {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("The last digit in first position: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("The exchanged second and third digits: {0}{1}{2}{3}", a, c, b, d);
    }
}


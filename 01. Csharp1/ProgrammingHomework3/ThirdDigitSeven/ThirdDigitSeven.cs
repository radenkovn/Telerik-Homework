// PROBLEM 5

using System;


class ThirdDigitSeven
{
    static void Main()
    {
        int integerNumber = int.Parse(Console.ReadLine());
        bool isThirdnumber= (integerNumber/100)%10==7;
        if (isThirdnumber)
        {
            Console.WriteLine("The third digit is 7!");
        }
        else
        {
            Console.WriteLine("The third digit is not 7!");
        }
    }
}


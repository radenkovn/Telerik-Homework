//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.


using System;

class ZeroesInN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int timesFive = 0;
        int checker;
        checker = n;
        // Every time we divide the number, we check how many 5^x times the number is present. The first time it's how many times 5 is present. The second time is how many times 25 is present,
        // The third time how many 625 are present, etc, until we reach a 5^x number which is bigger than our number.
        while (checker > 5)
        {
            timesFive += checker / 5;
            checker /= 5;
        }
        Console.WriteLine("In {0}! there are {1} zeroes at the end.", n, timesFive);
    }
}


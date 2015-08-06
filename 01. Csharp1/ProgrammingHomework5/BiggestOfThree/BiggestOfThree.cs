//PROBLEM 5

using System;


class BiggestOfThree
{
    static void Main()
    {
        double max = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        if (secondNumber > max)
        {
            max = secondNumber;
        }
        if (thirdNumber > max)
        {
            max = thirdNumber;
        }
        Console.WriteLine(max);
    }
}


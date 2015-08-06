//PROBLEM 6

using System;

class BiggestOfFive
{
    static void Main()
    {
        double max = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double fourthNumber = double.Parse(Console.ReadLine());
        double fifthNumber = double.Parse(Console.ReadLine());
        if (secondNumber > max)
        {
            max = secondNumber;
        }
        if (thirdNumber > max)
        {
            max = thirdNumber;
        }
        if (fourthNumber > max)
        {
            max = fourthNumber;
        }
        if (fifthNumber > max)
        {
            max = fifthNumber;
        }
        Console.WriteLine(max);
    }
}


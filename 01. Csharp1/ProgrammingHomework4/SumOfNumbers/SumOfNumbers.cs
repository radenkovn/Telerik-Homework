//PROBLEM 9

using System;
using System.Globalization;
using System.Threading;

class SumOfNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter how many numbers you want to enter: ");
        int firstSet = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < firstSet; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}


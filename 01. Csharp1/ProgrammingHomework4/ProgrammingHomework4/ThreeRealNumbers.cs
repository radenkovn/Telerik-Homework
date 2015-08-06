//Problem 1

using System;
using System.Globalization;
using System.Threading;


class ThreeRealNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter the first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number : ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the three numbers is {0}", sum);
    }
}


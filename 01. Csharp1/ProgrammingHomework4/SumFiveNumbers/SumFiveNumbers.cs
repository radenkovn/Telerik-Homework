//PROBLEM 7

using System;
using System.Globalization;
using System.Threading;


class SumFiveNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string fiveNumbers = Console.ReadLine();
        string[] number = fiveNumbers.Split(' ');
        double sum = 0;
        for (int i = 0; i < number.Length; i++)
        {
            sum += double.Parse(number[i]);
        }
        Console.WriteLine("The sum of the numbers is {0}", sum);
    }
}
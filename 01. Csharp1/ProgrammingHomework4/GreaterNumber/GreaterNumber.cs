//PROBLEM 4

using System;
using System.Globalization;
using System.Threading;


class GreaterNumber
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a: " );
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        while (a > b)
        {
            Console.WriteLine("The greater number is a: {0}", a);
            break;
        }
        while (b>a)
        {
            Console.WriteLine("The greater number is b: {0}", b);
            break;
        }
        while (b == a)
        {
            Console.WriteLine("The numbers are equal");
            break;
        }
    }
}


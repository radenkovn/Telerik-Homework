//PROBLEM 3

using System;
using System.Globalization;
using System.Threading;

class PerimeterArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double r = double.Parse(Console.ReadLine());
        double perimeter = Math.PI * 2 * r;
        double area = Math.PI * r * r;
        Console.WriteLine("The perimeter of the circle is {0: 0.00}, and it's area is {1:F2}.", perimeter, area);
    }
}


//PROBLEM 6

using System;
using System.Globalization;
using System.Threading;


class QuadraticEquation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("ax^2 + bx + c = 0");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
        double x;
        if (d > 0)
        {
            x = (-1 * b - Math.Sqrt(d)) / (2 * a);
            Console.Write("x1 = {0}, ", x);
            x = (-1 * b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x2 = {0}", x);
        }
        else if (d == 0)
        {
            x = (-1 * b) / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            Console.WriteLine("No real roots.");
        }

    }
}


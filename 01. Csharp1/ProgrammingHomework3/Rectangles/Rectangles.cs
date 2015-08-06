// PROBLEM 4

using System;


class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;
        Console.WriteLine("The perimeter of your rectangle is {0}, and its area is {1}.", perimeter, area);
    }
}
//PROBLEM 13
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class CompareFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double eps = 0.000001;
        if ( (Math.Abs(firstNumber - secondNumber)) < eps)
        {
            Console.WriteLine("The numbers are equal");
        }
        else 
        {
            Console.WriteLine("The numbers are not equal");
        }
    }
}


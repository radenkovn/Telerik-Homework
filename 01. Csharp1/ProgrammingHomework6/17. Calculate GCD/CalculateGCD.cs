//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

//  a 	    b 	    GCD(a, b)
//  3 	    2 	    1
//  60 	    40  	20
//  5 	    -15 	5


using System;
class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a < b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        int r;
        bool notFound = true;
        while (notFound)
        {
            r = a - b * (a / b);
            if (r == 0)
            {
                Console.WriteLine("GCD = {0}", b);
                notFound = false;
            }
            else
            {
                a = b;
                b = r;
            }
        }
    }
}


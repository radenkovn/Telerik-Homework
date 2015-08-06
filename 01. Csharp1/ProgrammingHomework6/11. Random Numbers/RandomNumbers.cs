//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

//n 	min 	max 	random numbers
//5 	0   	1   	1 0 0 1 1
//10 	10 	    15  	12 14 12 15 10 12 14 13 13 11

using System;


class RandomNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min;
        int max;
        do
        {
            Console.Write("Enter min: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Enter max: ");
            max = int.Parse(Console.ReadLine());
        }
        while (min == max);
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(r.Next(min, max + 1));
        }
    }
}


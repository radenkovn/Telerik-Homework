//Write a program that enters from the console a positive integer n and 
//prints all the numbers from 1 to n, on a single line, separated by a space.


// n 	output
// 3 	1 2 3
// 5 	1 2 3 4 5
using System;


class NumbersToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i != n)
            {
                Console.Write("{0} ", i);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}


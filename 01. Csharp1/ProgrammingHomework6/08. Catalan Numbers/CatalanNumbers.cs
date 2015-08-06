//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100). 

//  n 	Catalan(n)
//  0 	1
//  5 	42
//  10 	16796
//  15 	9694845

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter an integer between 1 and 100: ");
            n = int.Parse(Console.ReadLine());
        }
        while (n > 100 || n < 0);
        BigInteger nFac = 1;
        BigInteger nFacTwo = 1;
        BigInteger nFacPlusOne = 1;
        BigInteger result = 0;
        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
            nFacPlusOne *= (i + 1);
        }
        for (int j = 1; j <= n * 2; j++)
        {
            nFacTwo *= j;
        }
        result = nFacTwo / (nFac * nFacPlusOne);
        Console.WriteLine(result);
    }
}


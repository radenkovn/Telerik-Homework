
//In combinatorics, the number of ways to choose k different members out of a group of n different elements
//(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.


using System;
using System.Numerics;

class NFactorialK2
{
    static void Main()
    {
        int n;
        int k;
        Console.WriteLine("Enter n and k where n > k and both are less than 100 and greater than 1");
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            k = int.Parse(Console.ReadLine());

        }
        while (k < 1 || n < 1 || (k > n) || k > 100 || n > 100);
        BigInteger nFac = 1;
        BigInteger kFac = 1;
        BigInteger nMinusKFac = 1;
        BigInteger result;
        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
            if (i <= k)
            {
                kFac *= i;
            }
            if (i <= n - k)
            {
                nMinusKFac *= i;
            }
        }
        result = nFac / (kFac * nMinusKFac);
        Console.WriteLine(result);


    }
}


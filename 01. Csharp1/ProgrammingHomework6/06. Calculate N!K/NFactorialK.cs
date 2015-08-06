//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

// n 	k 	n! / k!
// 5 	2 	60
// 6 	5 	6
// 8 	3 	6720

using System;
using System.Numerics;
class NFactorialK
{
    static void Main()
    {
        int n;
        int k;
        BigInteger nFac = 1;
        BigInteger kFac = 1;
        Console.WriteLine("Enter n and k where n > k and both are less than 100 and greater than 1");
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            k = int.Parse(Console.ReadLine());

        }
        while (k < 1 || n < 1 || (k > n) || k > 100 || n > 100);

        for (int i = 1; i <= n; i++)
        {
            nFac *= i;
            if (i <= k)
            {
                kFac *= i;
            }
        }
        Console.WriteLine(nFac / kFac);
    }
}


//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.


using System;
using System.Collections.Generic;
using System.Linq;
class PrimeNumbers
{
    static void Main()
    {
        Console.WriteLine("This is slow.");
        int[] allNumbersList = Enumerable.Range(1, 100000).ToArray();
        for (int i = 1; i < allNumbersList.Length; i++)
        {
            if (allNumbersList[i] != -1)
            {
                for (int j = i; j < allNumbersList.Length; j++)
                {
                    if (j > i && allNumbersList[j] != -1)
                    {
                        if (allNumbersList[j] % allNumbersList[i] == 0)
                        {
                            allNumbersList[j] = -1;
                        }
                    }
                }
            }
        }
        List<int> distinctNumbers = allNumbersList.Distinct().ToList();
        distinctNumbers.Remove(-1);
        Console.WriteLine(string.Join(" ", distinctNumbers));
    }
}


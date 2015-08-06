//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Linq;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        Console.Write("Enter N between 1 and 100: ");
        int n = int.Parse(Console.ReadLine());
        NFac(n);
    }

    static void NFac(int n)
    {
        int[] numbers = Enumerable.Range(1, n).ToArray();
        BigInteger product = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            product *= numbers[i];
            Console.WriteLine("{0,2}!= {1}", i + 1, product);
        }
    }
}


//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class MaxKSum
{
    static void Main()
    {
        int n;
        int k;
        Console.WriteLine("Enter n > k");
        do
        {
            Console.Write("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            k = int.Parse(Console.ReadLine());
        }
        while (n < k);

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        for (int m = 0; m < k; m++)
        {
            maxSum += numbers[m];
        }

        for (int j = 0; j <= n - k; j++)
        {
            int currentSum = 0;
            for (int l = j; l < j + k; l++)
            {
                currentSum += numbers[l];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine("The max sum of this array is {0}", maxSum);
    }
}


//Write a program that finds the sequence of maximal sum in given array.



using System;

class MaxSum
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 10, 4, -8, 8 };
        int maxSum = 0;
        int maxCurrent = 0;
        int counter = 0;
        int lastIndex = 0;
        int lastCounter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            maxSum = maxSum + numbers[i];
            counter++;
            if (maxSum < 0)
            {
                maxSum = 0;
                counter = 0;
            }
            if (maxCurrent < maxSum)
            {
                maxCurrent = maxSum;
                lastCounter = counter;
                lastIndex = i + 1;
            }
        }


        for (int i = lastIndex - lastCounter; i < lastIndex; i++)
        {
            if (i == lastIndex - 1)
            {
                Console.WriteLine(numbers[i]);
            }
            else
            {
                Console.Write("{0} ", numbers[i]);
            }
        }
        Console.WriteLine("Their sum is {0}", maxCurrent);

    }
}


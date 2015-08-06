//Write a program that finds the most frequent number in an array.



using System;
class Frequent
{
    static void Main()
    {
        int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 4 };
        int maxTimes = 0;
        int frequent = 0; ;
        for (int i = 0; i < numbers.Length; i++)
        {
            int currentMax = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    currentMax++;
                }
            }
            if (currentMax > maxTimes)
            {
                frequent = numbers[i];
                maxTimes = currentMax;
            }
        }
        Console.WriteLine("The number {0} appears {1} times", frequent, maxTimes);
    }
}


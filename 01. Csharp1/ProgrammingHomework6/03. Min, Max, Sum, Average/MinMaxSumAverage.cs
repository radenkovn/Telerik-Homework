//Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.




using System;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int max;
        int min;
        int sum = 0;
        double average;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        max = numbers[0];
        min = numbers[0];
        for (int j = 1; j < n; j++)
        {
            if (max < numbers[j])
            {
                max = numbers[j];
            }
            if (min > numbers[j])
            {
                min = numbers[j];
            }
        }
        average = (double)sum / n;
        Console.WriteLine("Min = {0}\nMax = {1}\nSum= {2}\nAvg= {3:0.00}", min, max, sum, average);
    }
}


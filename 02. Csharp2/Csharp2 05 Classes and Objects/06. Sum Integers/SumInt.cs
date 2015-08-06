//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.


using System;
class SumInt
{
    static void Main()
    {
        Console.WriteLine("Enter your numbers, separated by spaces:");
        string input = Console.ReadLine();
        int sum = SumIntegers(input);
        Console.WriteLine("The sum of these numbers is {0}.", sum);
    }

    static int SumIntegers(string input)
    {
        string[] separated = input.Split(' ');
        int[] numbers = new int[separated.Length];
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(separated[i]);
            sum += numbers[i];
        }
        return sum;
    }
}


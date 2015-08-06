//Write a program that finds in given array of integers a sequence of given sum S (if present).


using System;
class SumInArray
{
    static void Main()
    {
        int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        int s = 30;

        int sum = 0;
        int currentCounter = 0;
        int index = 0;
        int finalcounter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = 0;
            currentCounter = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                currentCounter++;
                sum += numbers[j];
                if (sum == s)
                {
                    finalcounter = currentCounter - 1;
                    index = j;
                    break;
                }
            }
        }
        for (int l = index - finalcounter; l <= index; l++)
        {
            Console.WriteLine(numbers[l]);
        }
    }
}


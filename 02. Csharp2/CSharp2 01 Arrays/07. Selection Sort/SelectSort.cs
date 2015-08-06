//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;
class SelectSort
{
    static void Main()
    {
        int[] numbers = { 3, 4, 12, 5, 5, 43, 12, 23, 124, 123, 4535, 2, 312, 85, 23 };
        int min;
        int minIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            min = numbers[i];
            for (int j = i; j < numbers.Length; j++)
            {

                if (numbers[j] <= min)
                {
                    minIndex = j;
                    min = numbers[j];
                }
            }
            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}


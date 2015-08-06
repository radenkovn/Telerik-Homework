//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.



using System;
class BinarySearch
{
    static void Main()
    {
        int[] sortedNumbers = { 0, 2, 4, 5, 6, 7, 10, 13, 15, 23, 44 };
        int searchingFor = 15;
        bool found = false;
        int min = 0;
        int max = sortedNumbers.Length;
        while (min != max - 1)
        {
            int mid = min + ((max - min) / 2);
            if (sortedNumbers[mid] == searchingFor)
            {
                Console.WriteLine("The index of {0} is {1}", searchingFor, mid);
                found = true;
                break;
            }
            else if (sortedNumbers[mid] > searchingFor)
            {
                max = mid;
            }
            else
            {
                min = mid;
            }
        }
        if (found == false)
        {
            Console.WriteLine("Element not found");
        }
    }
}


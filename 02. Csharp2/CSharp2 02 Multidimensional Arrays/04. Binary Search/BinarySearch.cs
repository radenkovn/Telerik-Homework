//PROBLEM 4
//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;
class BinarySearch
{
    static void Main()
    {
        Console.Write("Etner n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Etner k: ");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter integer {0}:  ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);
        int index = Array.BinarySearch(numbers, k);
        if (index < 0)
        {
            index = ~index;
            if (index == 0)
            {
                Console.WriteLine("Not found. It is smaller than all the numbers inside the array.");
            }
            else if (index == numbers.Length)
            {
                Console.WriteLine("Not found. The highiest number which is <k is at index {0}, and is {1}.", numbers.Length - 1, numbers[numbers.Length - 1]);
            }
            else
            {
                Console.WriteLine("Not found. The highiest number which is <k is at index {0}, and is {1}.", index - 1, numbers[index - 1]);
            }
        }
        else
        {
            Console.WriteLine("Found at index {0}. The number is {1}.", index, numbers[index]);
        }

    }
}


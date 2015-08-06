//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.




using System;
class SortingArrays
{
    static void Main()
    {
        int[] numbers = { 1, -23, 3, 500, 6, 234, 54, 67, 3, 4, 5, 42, 453, 42, 231, 2 };
        string numbersAsString = string.Join(", ", numbers);
        Console.WriteLine("Your array is: \n\n{0}\n", numbersAsString);
        Console.Write("Enter a starting index: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("The maximum number after index {0} is {1}", index, MaxPortion(index, numbers));
        Console.WriteLine();

        ClumsySortDecr(numbers);
        Console.WriteLine("Sorted, decreasing order:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine();

        ClumsySortIncr(numbers);
        Console.WriteLine("Sorted, increasing order:");
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine();
    }

    static int MaxPortion(int index, int[] numbers)
    {
        int max = numbers[index];
        for (int i = index + 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static int[] ClumsySortDecr(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < MaxPortion(i, numbers))
            {
                int maxIndex = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[j] == MaxPortion(i, numbers))
                    {
                        maxIndex = j;
                        break;
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }
        }
        return numbers;
    }
    static int[] ClumsySortIncr(int[] numbers)
    {
        Array.Reverse(ClumsySortDecr(numbers));
        return numbers;
    }

}


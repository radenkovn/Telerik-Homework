//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 4, 3, 2, 1, 2 };
        string numbersAsString = string.Join(", ", numbers);
        Console.WriteLine("Your array is: \n\n{0}\n", numbersAsString);
        Console.Write("Enter a position to check: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (Larger(position, numbers))
        {
            Console.WriteLine("{0} is the {1}th element at index {2} and it is larger than its neighbours!", numbers[position - 1], position, position - 1);
        }
        else
        {
            Console.WriteLine("{0} is the {1}th element at index {2} and it is not larger than its neighbours!", numbers[position - 1], position, position - 1);
        }
        Console.WriteLine();
    }

    static bool Larger(int i, int[] numbers)
    {
        if (i == 1)
        {
            if (numbers[0] > numbers[1])
            {
                return true;
            }
        }
        else if (i == numbers.Length)
        {
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
            {
                return true;
            }
        }
        else
        {
            if (numbers[i - 2] < numbers[i - 1] && numbers[i - 1] > numbers[i])
            {
                return true;
            }
        }
        return false;
    }
}


//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;
class AppearanceCount
{
    static void Main()
    {
        int[] numbers = { 1, 43, 7, 3, 4, 2, 4, 5, 6, 43, 43, 43, 43, 5, 5, 6, 7, 7, 7, 7, 1, 1, 1 };
        string numbersAsString = string.Join(", ", numbers);
        Console.WriteLine("Your array is: \n\n{0}\n", numbersAsString);
        Console.Write("Enter the number you are searching for: ");
        int repeater = int.Parse(Console.ReadLine());


        int count = Counter(repeater, numbers);
        Console.WriteLine();
        Console.WriteLine("The number {0} appears {1} times in the array.", repeater, count);
        Console.WriteLine();
    }

    private static int Counter(int repeater, int[] numbers)
    {
        int count = 0;
        foreach (int a in numbers)
        {
            if (a == repeater)
            {
                count++;
            }
        }
        return count;
    }
}


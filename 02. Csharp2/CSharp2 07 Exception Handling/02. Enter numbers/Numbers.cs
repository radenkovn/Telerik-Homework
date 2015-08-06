//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//    If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100


using System;

class Numbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;

        int[] numbers = new int[10];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = ReadNumber(start, end);
        }
        string numbersAsStr = string.Join(", ", numbers);
        Console.WriteLine("Your array is: {0}", numbersAsStr);
    }

    private static int ReadNumber(int start, int end)
    {
        Console.Write("Enter a number between {0} and {1}: ", start, end);
        int result = 0;
        try
        {
            result = int.Parse(Console.ReadLine());
            if (result < start || result > end)
            {
                throw new ArgumentException();
            }
            return result;
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Not a valid number! Try again.");
            return ReadNumber(start, end);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Error: The number you entered is out of the boundaries. Try again.");
            return ReadNumber(start, end);
        }
    }
}


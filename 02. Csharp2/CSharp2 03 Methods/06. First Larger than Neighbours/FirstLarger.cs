//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;
class FirstLarger
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 4, 3, 2, 1, 2 };
        string numbersAsString = string.Join(", ", numbers);
        Console.WriteLine("Your array is: \n\n{0}\n", numbersAsString);
        int index = FirstLargerIndex(numbers);
        Console.WriteLine("The first Larger than neighbours index is index [{0}]. \nThe number is {1}.\n", index, numbers[index]);
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
    static int FirstLargerIndex(int[] numbers)
    {
        int final = -1;
        for (int counter = 0; counter < numbers.Length; counter++)
        {
            final = counter;
            if (Larger(final + 1, numbers))
            {
                break;
            }
        }
        return final;


    }
}


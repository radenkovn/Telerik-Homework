//Write a program that can solve these tasks:
//    Reverses the digits of a number
//    Calculates the average of a sequence of integers
//    Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//    The decimal number should be non-negative
//    The sequence should not be empty
//    a should not be equal to 0


using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("Welcome to the task solver!");
        Console.WriteLine("Choose 1, if you want to reverse the digits of a number.");
        Console.WriteLine("Choose 2, if you want to calculate the average of a sequence of integers.");
        Console.WriteLine("Choose 3, if you want to solve a linear equation.");
        Console.Write("Enter your choice here: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {
                    decimal number;
                    do
                    {
                        Console.Write("Enter a positive decimal number: ");
                        number = decimal.Parse(Console.ReadLine());
                    }
                    while (number < 0);
                    decimal reversed = ReverseNumber(number);
                    Console.WriteLine("The reversed number is: {0}", reversed);
                    break;
                }
            case 2:
                {
                    int length;
                    do
                    {
                        Console.Write("Enter how long your sequence shall be: ");
                        length = int.Parse(Console.ReadLine());
                    }
                    while (length <= 0);
                    int[] numbers = new int[length];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write("Enter number {0}: ", i + 1);
                        numbers[i] = int.Parse(Console.ReadLine());
                    }
                    decimal avg = AvgSeq(numbers);
                    Console.WriteLine("The average sum of those numebrs is {0:0.00}", avg);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("a * x + b = 0");
                    int a;
                    do
                    {
                        Console.Write("Enter a>0: ");
                        a = int.Parse(Console.ReadLine());
                    }
                    while (a == 0);
                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    decimal x = LinearSolve(a, b);
                    Console.WriteLine("x equals to {0:0.00}", x);
                    break;
                }
            default: Console.WriteLine("That was not a valid choice!");
                break;
        }

    }

    private static decimal LinearSolve(int a, int b)
    {
        return (decimal)-1 * b / a;
    }

    static decimal AvgSeq(int[] numbers)
    {
        decimal sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        decimal avg = sum / numbers.Length;
        return avg;
    }
    static decimal ReverseNumber(decimal number)
    {
        char[] numberAsArr = (number.ToString()).ToCharArray();
        Array.Reverse(numberAsArr);
        string reversedString = string.Join("", numberAsArr);
        return decimal.Parse(reversedString);
    }

}


//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


using System;
using System.Numerics;
class IntCalcs
{
    static void Main()
    {
        int length;
        do
        {
            Console.Write("Enter the ammount of numbers you want to use: ");
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
        Console.WriteLine("The AVERAGE sum of the numbers is {0:0.00}.", avg);
        int max = Max(numbers);
        Console.WriteLine("The MAX out of the numbers is {0}.", max);
        int min = Min(numbers);
        Console.WriteLine("The MIN out of the numbers is {0}.", min);
        int sum = Sum(numbers);
        Console.WriteLine("The SUM of the numbers is {0}.", sum);
        BigInteger product = Product(numbers);
        Console.WriteLine("The PRODUCT of the numbers is {0}.", product);


    }
    static int Max(int[] numbers)
    {
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static int Min(int[] numbers)
    {
        int min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
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
    static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
    static BigInteger Product(int[] numbers)
    {
        BigInteger product = 1;
        foreach (int number in numbers)
        {
            product *= number;
        }
        return product;
    }
}


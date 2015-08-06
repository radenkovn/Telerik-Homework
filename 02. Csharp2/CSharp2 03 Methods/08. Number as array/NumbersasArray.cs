//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Numerics;

class NumbersAsArray
{
    static void Main()
    {
        Console.Write("Enter number one: ");
        BigInteger first = BigInteger.Parse(Console.ReadLine());
        Console.Write("Enter number two: ");
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger sum = AddAsArray(first, second);
        Console.WriteLine("The sum of the two numbers, added as arrays is {0}", sum);
    }
    // takes two numbers, converts them to arrays, whose index 0 is the last digit of
    // the numbers, then adds the elements up, then converts the result array back to a number
    static BigInteger AddAsArray(BigInteger first, BigInteger second)
    {
        BigInteger[] firstArr = NumberToArray(first);
        BigInteger[] secondArr = NumberToArray(second);
        BigInteger[] resultArr = new BigInteger[Math.Max(firstArr.Length, secondArr.Length)];

        if (firstArr.Length >= secondArr.Length)
        {
            for (int i = 0; i < secondArr.Length; i++)
            {
                resultArr[i] = firstArr[i] + secondArr[i];
            }
            for (int i = secondArr.Length; i < firstArr.Length; i++)
            {
                resultArr[i] = firstArr[i];
            }
        }
        else
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                resultArr[i] = firstArr[i] + secondArr[i];
            }
            for (int i = firstArr.Length; i < secondArr.Length; i++)
            {
                resultArr[i] = secondArr[i];
            }
        }

        return ArrToNumber(resultArr);
    }
    //converts a number to an array where the last digit is at index 0
    static BigInteger[] NumberToArray(BigInteger number)
    {
        string numberString = number.ToString();
        BigInteger[] numberArr = new BigInteger[numberString.Length];
        for (int i = 0; i < numberArr.Length; i++)
        {
            numberArr[i] = number % 10;
            number /= 10;
        }
        return numberArr;
    }
    //converts an array, whose index 0 is the last digit of a number, to the number.
    static BigInteger ArrToNumber(BigInteger[] arr)
    {
        Array.Reverse(arr);
        string numberString = string.Join("", arr);
        BigInteger result = BigInteger.Parse(numberString);
        return result;
    }
}


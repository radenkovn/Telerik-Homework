//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().


using System;
class LargestNumber
{
    static void Main()
    {
        Console.Write("Enter integet 1: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter integet 2: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter integet 3: ");
        int third = int.Parse(Console.ReadLine());
        int max = GetMax(GetMax(first, second), third);
        Console.WriteLine("The largest out of those numbers is {0}.", max);
    }

    static int GetMax(int first, int second)
    {
        if (first > second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

}


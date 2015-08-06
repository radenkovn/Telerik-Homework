//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
class CompareArrays
{
    static void Main()
    {
        int[] firstArray = new int[5];
        int[] secondArray = new int[5];
        bool same = true;
        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < firstArray.Length; j++)
        {
            secondArray[j] = int.Parse(Console.ReadLine());
        }
        for (int k = 0; k < firstArray.Length; k++)
        {

            if (firstArray[k] != secondArray[k])
            {
                same = false;
                break;
            }
        }
        Console.WriteLine(same);
    }
}


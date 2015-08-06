

//Write a program that sorts an array of integers using the Quick sort algorithm.


using System;
class QuickSort
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 10, 4, -8, 8 };
        SortArray(numbers);
        string numersString = string.Join(", ", numbers);
        Console.WriteLine(numersString);
    }
    public static void SortArray(int[] arr)
    {

        if (arr.Length > 0)
        {

            int pivot = arr[0];
            int smallCount = 0;
            int bigCount = 0;
            int sameCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (pivot > arr[i])
                {
                    smallCount++;
                }
                else if (pivot < arr[i])
                {
                    bigCount++;
                }
                else
                {
                    sameCount++;
                }
            }

            int[] smallNumbers = new int[smallCount];
            int[] sameNumbers = new int[sameCount];
            int[] bigNumbers = new int[bigCount];

            for (int i = 0; i < smallNumbers.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (pivot > arr[j])
                    {
                        smallNumbers[i] = arr[j];
                        i++;
                    }
                }
                SortArray(smallNumbers);
            }

            for (int i = 0; i < sameNumbers.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (pivot == arr[j])
                    {
                        sameNumbers[i] = arr[j];
                        i++;
                    }
                }
            }

            for (int i = 0; i < bigNumbers.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (pivot < arr[j])
                    {
                        bigNumbers[i] = arr[j];
                        i++;
                    }
                }
                SortArray(bigNumbers);
            }



            for (int i = 0; i < smallNumbers.Length; i++)
            {
                arr[i] = smallNumbers[i];
            }
            for (int i = smallNumbers.Length; i < smallNumbers.Length + sameNumbers.Length; i++)
            {
                arr[i] = sameNumbers[i - smallNumbers.Length];
            }
            for (int i = smallNumbers.Length + sameNumbers.Length; i < arr.Length; i++)
            {
                arr[i] = bigNumbers[i - (smallNumbers.Length + sameNumbers.Length)];
            }
        }
        else
        {
            return;
        }
    }
}


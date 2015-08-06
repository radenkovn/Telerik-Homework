//Write a program that finds the maximal sequence of equal elements in an array.


using System;


class MaxSeq
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1, 10, 11, 13, 13, 13, 13, 13, 13, 13, 13, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4 };
        int currentIndex;
        int currentCounter;
        int maxCounter = 1;
        int maxIndex = 0;
        bool nextSame;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentIndex = i;
                nextSame = true;
                while (nextSame && currentIndex < numbers.Length)
                {
                    if (numbers[currentIndex] == numbers[currentIndex + 1])
                    {
                        maxCounter++;
                        currentIndex++;
                    }
                    else
                    {
                        nextSame = false;
                    }
                }
                maxIndex = currentIndex - maxCounter + 1;
                break;
            }
        }


        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentCounter = 1;
            if (numbers[i] == numbers[i + 1])
            {
                currentIndex = i;
                nextSame = true;
                while (nextSame && currentIndex < numbers.Length - 1)
                {
                    if (numbers[currentIndex] == numbers[currentIndex + 1])
                    {
                        currentCounter++;
                        currentIndex++;
                    }
                    else
                    {
                        i = currentIndex;
                        nextSame = false;
                    }
                }
                if (currentCounter > maxCounter)
                {
                    maxCounter = currentCounter;
                    maxIndex = currentIndex - maxCounter + 1;
                }
            }
        }
        if (maxCounter == 1)
        {
            Console.WriteLine("No sequence detected!");
        }
        else
        {
            for (int j = maxIndex; j < maxIndex + maxCounter; j++)
            {
                Console.Write("Index: {0}, number: {1}\n", j, numbers[j]);
            }
            Console.WriteLine("The length of the Sequence is {0}", maxCounter);
        }
    }
}

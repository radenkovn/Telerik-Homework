//Write a program that finds the maximal increasing sequence in an array.



using System;


class MaxSeq
{
    static void Main()
    {
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1, 10, 11, 13, 13, 13, 13, 14, 15, 16, 17, 13, 13, 13, 13, 6, 6, 6, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 6, 6, 6, 6, 6, 6, 6, 4 };
  
        int maxCounter = 1;
        int maxIndex = 0;
        bool nextSame;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] + 1 == numbers[i + 1])
            {
                maxIndex = i;
                nextSame = true;
                while (nextSame && maxIndex < numbers.Length)
                {
                    if (numbers[maxIndex] + 1 == numbers[maxIndex + 1])
                    {
                        maxCounter++;
                        maxIndex++;
                    }
                    else
                    {
                        nextSame = false;
                    }
                }
                maxIndex = maxIndex - maxCounter + 1;
                break;
            }
        }

        int currentIndex;
        int currentCounter;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            currentCounter = 1;
            if (numbers[i] + 1 == numbers[i + 1])
            {
                currentIndex = i;
                nextSame = true;
                while (nextSame && currentIndex < numbers.Length - 1)
                {
                    if (numbers[currentIndex] + 1 == numbers[currentIndex + 1])
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

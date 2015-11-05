namespace _04.Longest_SubSequence
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1, 10, 11, 13, 13, 13, 13, 13, 13, 13, 13, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 4 };
            var subSequence = GetMaxSequence(numbers);
            Console.WriteLine(string.Join(", ", subSequence));
            Console.WriteLine("The length of the Sequence is {0}", subSequence.Count);
        }

        public static List<int> GetMaxSequence(List<int> numbers)
        {
            var subSequence = new List<int>();
            int currentIndex;
            int maxCounter = 1;
            int maxIndex = 0;
            bool nextSame;
            var count = numbers.Count;

            for (int i = 0; i < count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentIndex = i;
                    nextSame = true;
                    while (nextSame && currentIndex < count)
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

            int currentCounter;

            for (int i = 0; i < count - 1; i++)
            {
                currentCounter = 1;
                if (numbers[i] == numbers[i + 1])
                {
                    currentIndex = i;
                    nextSame = true;
                    while (nextSame && currentIndex < count - 1)
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
                    subSequence.Add(numbers[j]);
                }
            }
            return subSequence;
        }
    }
}

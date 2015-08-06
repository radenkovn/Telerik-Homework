namespace DecreasingAbsoluteDifference
{
    using System;
    using System.Numerics;

    class EntryPoint
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = new int[input.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[j] = int.Parse(input[j]);
                }

                BigInteger[] absArr = GetAbsoluteSequence(numbers);
                bool isDecreasing = IsDecreasingSequence(absArr);
                Console.WriteLine(isDecreasing);
            }
        }

        public static BigInteger[] GetAbsoluteSequence(int[] numbers)
        {
            BigInteger[] absoluteSequence = new BigInteger[numbers.Length - 1];
            int counter = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[i - 1];
                BigInteger difference = Math.Abs(currentNumber - nextNumber);
                absoluteSequence[counter] = difference;
                counter++;
            }
            return absoluteSequence;
        }

        public static bool IsDecreasingSequence(BigInteger[] array)
        {
            bool isDecreasing = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (!(array[i] == array[i - 1] || array[i] == array[i - 1] - 1))
                {
                    isDecreasing = false;
                    break;
                }
            }
            return isDecreasing;
        }
    }
}
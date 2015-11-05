namespace _08.Majorant
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] numbers = { 1, 2, 2, 2, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5 };

            Console.WriteLine("The numbers: ");
            Console.WriteLine(string.Join(", ", numbers));

            GetRepetitions(numbers);
        }

        public static void GetRepetitions(int[] numbers)
        {
            var numberRepetitions = new Dictionary<int, int>();
            int numbersLength = numbers.Length;
            for (int i = 0; i < numbersLength; i++)
            {
                var currentNumber = numbers[i];
                if (!numberRepetitions.ContainsKey(currentNumber))
                {
                    numberRepetitions.Add(currentNumber, 1);
                }
                else
                {
                    numberRepetitions[currentNumber]++;
                }
            }

            int maxCount = 0;
            int? maxNumber = null;

            foreach (var numberPair in numberRepetitions)
            {
                var currentNumber = numberPair.Key;
                var repetitions = numberPair.Value;
                if (repetitions >= numbersLength / 2 + 1)
                {
                    maxCount = repetitions;
                    maxNumber = currentNumber;
                }
            }

            if (maxNumber != null)
            {
                Console.WriteLine("The majorant of the sequence is: {0} and it is repeated {1} times", maxNumber, maxCount);
            }
            else
            {
                Console.WriteLine("No majorant found");
            }
        }
    }
}

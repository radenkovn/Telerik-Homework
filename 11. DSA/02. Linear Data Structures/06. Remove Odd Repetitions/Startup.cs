namespace _06.Remove_Odd_Repetitions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 2, 3, 4, 4, 4, 5, 5 };

            Console.WriteLine("Before the method: ");
            Console.WriteLine(string.Join(", ", numbers));

            RemoveOddRepetitions(numbers);
            Console.WriteLine("After the method:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void RemoveOddRepetitions(List<int> numbers)
        {
            var numberRepetitions = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
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

            foreach (var numberPair in numberRepetitions)
            {
                if (numberPair.Value % 2 != 0 && numberPair.Value > 1)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers.Remove(numberPair.Key);
                    }
                }
            }
        }
    }
}

namespace _07.Repetitions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 2, 3, 4, 4, 4, 5, 5 };

            Console.WriteLine("The numbers: ");
            Console.WriteLine(string.Join(", ", numbers));

            GetRepetitions(numbers);
        }

        public static void GetRepetitions(List<int> numbers)
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

            Console.WriteLine();
            foreach (var numberPair in numberRepetitions)
            {
                Console.WriteLine("{0} => {1} times", numberPair.Key, numberPair.Value);
            }
        }
    }
}

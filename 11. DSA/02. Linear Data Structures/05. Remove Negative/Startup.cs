namespace _05.Remove_Negative
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 3, 4, 12, 5, -5, 43, 12, 23, -124, -123, 4535, 2, 312, 85, 23 };

            Console.WriteLine("Before the method: ");
            Console.WriteLine(string.Join(", ", numbers));

            RemoveNegatives(numbers);
            Console.WriteLine("After the method:");
            Console.WriteLine(string.Join(", ", numbers));
        }

        public static void RemoveNegatives(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber < 0)
                {
                    numbers.Remove(currentNumber);
                }
            }
        }
    }
}

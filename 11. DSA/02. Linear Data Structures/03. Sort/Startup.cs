namespace _03.Sort
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = new List<int> { 3, 4, 12, 5, 5, 43, 12, 23, 124, 123, 4535, 2, 312, 85, 23 };

            Console.WriteLine("Before the sort: ");
            Console.WriteLine(string.Join(", ", numbers));

            SelectionSort(numbers);
            Console.WriteLine("After the sort:");
            Console.WriteLine(string.Join(", ", numbers));

            //var input = Console.ReadLine();
            //var userNumbers = new List<int>();
            //while (input != string.Empty)
            //{
            //    var currentNumber = int.Parse(input);
            //    userNumbers.Add(currentNumber);
            //    input = Console.ReadLine();
            //}
            //SelectionSort(userNumbers);
            //Console.WriteLine(string.Join(", ", numbers));
        }

        public static void SelectionSort(List<int> numbers)
        {
            int min;
            int minIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                min = numbers[i];
                for (int j = i; j < numbers.Count; j++)
                {

                    if (numbers[j] <= min)
                    {
                        minIndex = j;
                        min = numbers[j];
                    }
                }
                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }
    }
}

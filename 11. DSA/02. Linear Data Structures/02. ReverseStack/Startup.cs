namespace _02.ReverseStack
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var orderedNumbers = new Stack<int>();
            while (input != string.Empty)
            {
                var currentNumber = int.Parse(input);
                orderedNumbers.Push(currentNumber);
                input = Console.ReadLine();
            }

            var reversedNumbers = new List<int>();

            var numbersCount = orderedNumbers.Count;
            
            for (int i = 0; i < numbersCount; i++)
            {
                reversedNumbers.Add(orderedNumbers.Pop());
            }

            Console.WriteLine(string.Join(", ", reversedNumbers));
        }
    }
}

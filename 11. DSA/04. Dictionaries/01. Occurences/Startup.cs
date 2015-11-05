namespace _01.Occurences
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            double[] numbers = { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var dictionary = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 1;
                }
                else
                {
                    dictionary[number] += 1;
                }
            }

            foreach (var numberPair in dictionary)
            {
                Console.WriteLine("{0} is present {1} times in the dictionary", numberPair.Key, numberPair.Value);
            }
        }
    }
}

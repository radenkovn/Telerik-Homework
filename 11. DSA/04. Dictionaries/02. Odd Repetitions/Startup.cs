namespace _02.Odd_Repetitions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            string[] words = { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = 1;
                }
                else
                {
                    dictionary[word] += 1;
                }
            }

            foreach (var wordPair in dictionary)
            {
                if (wordPair.Value % 2 == 1)
                {
                    Console.WriteLine("{0} is present {1} times in the dictionary", wordPair.Key, wordPair.Value);
                }
            }
        }
    }
}

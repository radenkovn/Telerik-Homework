namespace _03.Word_Repetitions
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        static void Main()
        {
            string text = "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?";
            char[] splitOptions = { ' ', '.', ',', '?', '!', '-', '–' };
            var words = text.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var currentKey = word.ToLower();
                if (!dictionary.ContainsKey(currentKey))
                {
                    dictionary[currentKey] = 1;
                }
                else
                {
                    dictionary[currentKey] += 1;
                }
            }

            foreach (var wordPair in dictionary)
            {
                Console.WriteLine("{0,15} is present {1} times in the dictionary", wordPair.Key, wordPair.Value);
            }
        }
    }
}

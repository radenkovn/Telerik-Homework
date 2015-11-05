namespace _01.Positive_Integer_Numbers
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sequence = new Sequence();

            while (input != string.Empty)
            {
                var currentNumber = int.Parse(input);
                sequence.Add(currentNumber);
                input = Console.ReadLine();
            }

            Console.WriteLine("The sum of your sequence is: {0}", sequence.Sum());
            Console.WriteLine("The avg of your sequence is: {0}", sequence.Average());
        }
    }
}

namespace _9.QueueExample
{
    using System;
    using System.Collections.Generic;
    public class Startup
    {
        static void Main()
        {
            var sequence = new Queue<int>();
            var firstNumber = 2;

            sequence.Enqueue(firstNumber);

            for (int i = 0; i < 50; i++)
            {
                var currentNumber = sequence.Dequeue();

                Console.WriteLine(currentNumber);

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue(2 * currentNumber + 1);
                sequence.Enqueue(currentNumber + 2);
            }
        }
    }
}

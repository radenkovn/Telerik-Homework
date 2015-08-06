namespace Refactoringloops
{
    using System;

    class EntryPoint
    {
        static void Main(string[] args)
        {
            var array = new int[100];
            var expectedValue = 50;
            var found = false;

            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                Console.WriteLine(currentNumber);
                var index = i;
                var correctIndexAndValue = (index % 10 == 0) && (currentNumber == expectedValue);
                if (correctIndexAndValue)
                {
                    found = true;
                    break;
                }
            }
            // More code here
            if (found)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}

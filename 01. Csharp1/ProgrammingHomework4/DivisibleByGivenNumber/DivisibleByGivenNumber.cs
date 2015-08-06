//PROBLEM 11

using System;


class DivisibleByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        uint firstNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter a positive number: ");
        uint secondNumber = uint.Parse(Console.ReadLine());
        int counter = 0;
        if (firstNumber < secondNumber)
        {
            for (int i = (int)firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("There is/are {0} divisible number(s)", counter);
        }
        else if (firstNumber > secondNumber)
        {
            for (int i = (int)secondNumber; i <= firstNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("There is/are {0} divisible number(s)", counter);
        }
        else
        {
            if (firstNumber % 5 == 0)
            {
                counter = 1;
                Console.WriteLine("There is only {0} divisible number", counter);
            }
            else
            {
                Console.WriteLine("There are {0} divisible numbers", counter);
            }
        }
    }
}

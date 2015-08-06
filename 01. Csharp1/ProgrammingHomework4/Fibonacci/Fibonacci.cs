//PROBLEM 10

using System;


class Fibonacci
{
    static void Main()
    {
        int numberOne = 0;
        int numberTwo = 1;
        int switcher;
        int index = int.Parse(Console.ReadLine());
        Console.Write(numberOne);
        for (int i = 0; i < index-1; i++)
        {
            Console.Write(" " + numberTwo);
            switcher = numberOne;
            numberOne = numberTwo;
            numberTwo = switcher + numberOne;
            if (i == index - 2)
            {
                Console.WriteLine();
            }
        }
    }
}


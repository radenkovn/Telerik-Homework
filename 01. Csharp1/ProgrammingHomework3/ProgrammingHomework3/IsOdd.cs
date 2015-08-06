//PROBLEM 1

using System;


class IsOdd
{
    static void Main()
    {
        int isOdd = int.Parse(Console.ReadLine());
        bool checkIfOdd = isOdd % 2 == 1;
        if (checkIfOdd)
        {
            Console.WriteLine("The number you entered is odd!");
        }
        else
        {
            Console.WriteLine("The number you entered is NOT odd!");
        }
    }
}


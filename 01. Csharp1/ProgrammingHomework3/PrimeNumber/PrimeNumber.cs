//PROBLEM 8

using System;


class PrimeNumber
{
    static void Main()
    {
        int n;
        bool isNotPrime = false;

        do
        {
            Console.Write("Enter a number which is less than 100:  ");
            n = int.Parse(Console.ReadLine());
        }
        while (n > 100);

        if (n > 0)
        {
            for (int i = 2; i < ((n / 2) + 1); i++)// We check from 2 to the number, (divided by 2)+1, since there is no point to check further.
            {
                isNotPrime = n % i == 0;
                if (isNotPrime)
                {
                    break;
                }
            }
        }

        if (!isNotPrime && n > 0 && n != 1) // Negative numbers and 1 are not prime.
        {
            Console.WriteLine("This number is Prime!");
        }
        else
        {
            Console.WriteLine("This number is not Prime!");
        }
    }
}


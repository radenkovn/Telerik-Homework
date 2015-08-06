//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.


using System;


class RandomNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int l;
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }
        for (int j = 0; j < n; j++)
        {
            l = r.Next(0, n);
            if (numbers[l] != 0)
            {
                Console.Write("{0} ",numbers[l]);
                numbers[l] = 0;
            }
            else
            {
                j = j - 1;
            }
            if (j == n - 1)
            {
                Console.WriteLine();
            }
        }
    }
}


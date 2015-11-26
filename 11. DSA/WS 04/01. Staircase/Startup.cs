﻿namespace _01.Staircase
{
    using System;

    class Startup
    {
        static long[,] count;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            count = new long[n + 1, n + 1];

            long answer = 0;

            count[0, 0] = 1;
            count[1, 1] = 1;
            count[2, 2] = 1;

            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < j && i-j >=k; k++)
                    {
                        count[i, j] += count[i - j, k];
                    }
                }
            }


            for (int i = 1; i < n; i++)
            {

                answer += count[n, i];
            }

            Console.WriteLine(answer);
        }
    }
}

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomN
{
    static void Main()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            int generated = random.Next(100, 200);
            Console.WriteLine("Number {0}: {1}", i + 1, generated);
        }
    }
}


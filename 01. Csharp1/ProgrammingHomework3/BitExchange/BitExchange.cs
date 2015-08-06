//PROBLEM 14

using System;

class BitExchange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int shifter;
        int endResult;
        if (v == 0)
        {
            shifter = ~(1 << p);
            endResult = n & shifter;
        }
        else
        {
            shifter = v << p;
            endResult = n | shifter;
        }
        Console.WriteLine("The new number is {0}", endResult);
    }
}
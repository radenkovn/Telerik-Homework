//PROBLEM 9

using System;

class VariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Now a is equal to {0}, and b is equal to {1}.", a, b);
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("Now a is equal to {0}, and b is equal to {1}.", a, b);
    }
}


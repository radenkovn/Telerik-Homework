//PROBLEM 12

using System;


class ExtractBit
{
    static void Main()
    {
        int unsignedInt = int.Parse(Console.ReadLine());
        int move = int.Parse(Console.ReadLine());
        int checker = 1 << move;
        int beforeShift = checker & unsignedInt;
        int digit = beforeShift >> move;
        Console.WriteLine("The {0} bit is {1}", move, digit);
    }
}

//PROBLEM 11

using System;


class BitwiseExtract3
{
    static void Main()
    {
        uint unsignedInt = uint.Parse(Console.ReadLine());
        int move = 3;
        int checker = 1 << move;
        int beforeShift = checker & (int)unsignedInt;
        int digit = beforeShift >> move;
        Console.WriteLine("The third bit is {0}",digit);
    }
}

//PROBLEM 13

using System;


class CheckBitPosition
{
    static void Main()
    {
        int unsignedInt = int.Parse(Console.ReadLine());
        int move = int.Parse(Console.ReadLine());
        int checker = 1 << move;
        int beforeShift = checker & unsignedInt;
        int digit = beforeShift >> move;
        bool isOne = digit==1;
        if (isOne)
        {
            Console.WriteLine("The {0} digit is 1! {1}", move, isOne);
        }
        else
        {
            Console.WriteLine("The {0} digit is not 1! {1}", move, isOne);
        }
    }
}

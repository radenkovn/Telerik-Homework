//PROBLEM 15

using System;

class ThreeBitsExchange
{
    static void Main()
    {
        uint unsignedInt = uint.Parse(Console.ReadLine());
        //extracting positions 24-26
        int move = 24;
        int checker = 1 << move;
        int beforeShift = checker & (int)unsignedInt;
        int twentyFour = beforeShift >> move++;

        checker = 1 << move;
        beforeShift = checker & (int)unsignedInt;
        int twentyFive = beforeShift >> move++;

        checker = 1 << move;
        beforeShift = checker & (int)unsignedInt;
        int twentySix = beforeShift >> move;
        //extracting positions 3-5
        move = 3;

        checker = 1 << move;
        beforeShift = checker & (int)unsignedInt;
        int three = beforeShift >> move++;

        checker = 1 << move;
        beforeShift = checker & (int)unsignedInt;
        int four = beforeShift >> move++;

        checker = 1 << move;
        beforeShift = checker & (int)unsignedInt;
        int five = beforeShift >> move;
        //assigning numbers 24-26 to positions 3-5
        move = 3;
        int endReslut= (int)unsignedInt;
        if (twentyFour == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }

        move = 4;
        if (twentyFive == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }
        move = 5;
        if (twentySix == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }
        //assigning numbers 3-5 to positions 24-26
        move = 24;
        if (three == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }

        move = 25;
        if (four == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }

        move = 26;
        if (five == 0)
        {
            beforeShift = ~(1 << move);
            endReslut = endReslut & beforeShift;
        }
        else
        {
            beforeShift = 1 << move;
            endReslut = endReslut | beforeShift;
        }
        Console.WriteLine((uint)endReslut);
    }
}


//PROBLEM 16

using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int checkerOne;
        int checkerTwo;
        int beforeShiftOne;
        int beforeShiftTwo;
        int endResult = (int)n;
        int currentBitOne;
        int currentBitTwo;

        for (int i = p; i < p + k; i++)
        {
            for (int j = q; j < q + k; j++)
            {
                checkerOne = 1 << i;
                beforeShiftOne = checkerOne & (int)n;
                currentBitOne = beforeShiftOne >> p;
                checkerTwo = 1 << j;
                beforeShiftTwo = checkerTwo & (int)n;
                currentBitTwo = beforeShiftTwo >> j;
                if (currentBitOne == 0)
                {
                    beforeShiftOne = ~(1 << j);
                    endResult = endResult & beforeShiftOne;
                }
                else
                {
                    beforeShiftOne = 1 << j;
                    endResult = endResult | beforeShiftOne;
                }
                if (currentBitTwo == 0)
                {
                    beforeShiftTwo = ~(1 << i);
                    endResult = endResult & beforeShiftTwo;
                }
                else
                {
                    beforeShiftTwo = 1 << i;
                    endResult = endResult | beforeShiftTwo;
                }
            }
        }

        Console.WriteLine((uint)endResult);



        //checker = 1 << p;
        //int beforeShift = checker & (int)n;
        //int twentyFour = beforeShift >> p++;

        //checker = 1 << p;
        //beforeShift = checker & (int)n;
        //int twentyFive = beforeShift >> p++;

        //checker = 1 << p;
        //beforeShift = checker & (int)n;
        //int twentySix = beforeShift >> p;
        ////extracting positions 3-5
        //p = 3;

        //checker = 1 << p;
        //beforeShift = checker & (int)n;
        //int three = beforeShift >> p++;

        //checker = 1 << p;
        //beforeShift = checker & (int)n;
        //int four = beforeShift >> p++;

        //checker = 1 << p;
        //beforeShift = checker & (int)n;
        //int five = beforeShift >> p;
        ////assigning numbers 24-26 to positions 3-5
        //p = 3;
        //int endReslutOne= (int)n;
        //if (twentyFour == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}

        //p = 4;
        //if (twentyFive == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}
        //p = 5;
        //if (twentySix == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}
        ////assigning numbers 3-5 to positions 24-26
        //p = 24;
        //if (three == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}

        //p = 25;
        //if (four == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}

        //p = 26;
        //if (five == 0)
        //{
        //    beforeShift = ~(1 << p);
        //    endReslutOne = endReslutOne & beforeShift;
        //}
        //else
        //{
        //    beforeShift = 1 << p;
        //    endReslutOne = endReslutOne | beforeShift;
        //}
        //Console.WriteLine((uint)endReslutOne);
    }
}


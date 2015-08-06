// PROBLEM 12

using System;

class NullValues
{
    static void Main()
    {
        int? integerNull = null;
        double? doublNull = null;
        Console.WriteLine(integerNull + "\n" + doublNull);
        Console.WriteLine(integerNull + 1);
        Console.WriteLine(doublNull + 3);
        Console.WriteLine(integerNull + null);
        Console.WriteLine(doublNull + null);
        //NOTHING HAPPENS :D!
    }
}

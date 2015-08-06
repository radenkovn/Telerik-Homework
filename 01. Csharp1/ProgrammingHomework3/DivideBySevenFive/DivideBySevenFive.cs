//PROBLEM 3

using System;


class DivideBySevenFive
{
    static void Main()
    {
        int integerNumber = int.Parse(Console.ReadLine());
        bool divisibleSimple = integerNumber % 35 == 0; // Simply BY 35
        bool divisibleComplex = (integerNumber % 5 == 0) && (integerNumber % 7 == 0);// By 5 AND by 7
        Console.WriteLine(divisibleSimple);
        Console.WriteLine(divisibleComplex);
    }
}


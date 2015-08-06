//PROBLEM 1
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort,
//int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

using System;


class DeclareVariables
{
    static void Main()
    {
        ushort unsignedShortNumber = 52130;
        sbyte signedByteNumber = -115;
        int integerNumber = 4825932;
        byte byteNumber = 97;
        short shortNumber = -10000;
        Console.WriteLine(unsignedShortNumber + "\n" + signedByteNumber + "\n" + integerNumber + "\n" + byteNumber + "\n" + shortNumber);
    }
}

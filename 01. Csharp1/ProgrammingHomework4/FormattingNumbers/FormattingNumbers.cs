//PROBLEM 5

using System;


class FormattingNumbers
{
    static void Main()
    {
        int a;
        do
        {
            Console.Write("Enter an integer between 0 and 500 a: ");
            a = int.Parse(Console.ReadLine());
        }
        while(a < 0 || a> 500);
        Console.Write("Enter number b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        float c = float.Parse(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(10,'0');

        Console.WriteLine("{0,-10 :X}|{1}|{2,10 :0.00}|{3,-10:0.000}|", a, binaryA, b, c);
        Console.WriteLine("{0,-10 :X}|{1}|{2,10 :0.00}|{3,-10:0.000}|", a * 23, binaryA, b * 23.4f, c * 23.4f);
    }
}


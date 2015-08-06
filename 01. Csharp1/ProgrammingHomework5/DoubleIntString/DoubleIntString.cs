using System;



class DoubleIntString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int decider = int.Parse(Console.ReadLine());

        switch (decider)
        {
            case 1: int integerNumber = int.Parse(Console.ReadLine()); Console.WriteLine(integerNumber + 1); break;
            case 2: double doubleNumber = double.Parse(Console.ReadLine()); Console.WriteLine(doubleNumber + 1); break;
            case 3: string stringVariable = Console.ReadLine(); Console.WriteLine(stringVariable + "*"); break;
            default: break;
        }
    }
}


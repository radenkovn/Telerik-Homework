using System;

class SequencePrint
{
    static void Main()
    {
        int sequenceNumberOne = 2;
        int sequenceNumberTwo = -3;

        for (int i = 0; i < 4; i++)
        {
            Console.Write(sequenceNumberOne + ", " + sequenceNumberTwo + ", ");
            sequenceNumberOne += 2;
            sequenceNumberTwo -= 2;            
        }
        Console.Write(sequenceNumberOne + ", " + sequenceNumberTwo);
        sequenceNumberOne += 2;
        sequenceNumberTwo -= 2;

        Console.WriteLine("\n2, -3, 4, -5, 6, -7, 8, -9, 10, -11"); // Simple WriteLine of the sequence itself.
    }
}

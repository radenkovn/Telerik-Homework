using System;

class LongSequence
{
    static void Main()
    {
        int sequenceNumberOne = 2;
        int sequenceNumberTwo = -3;
        for (int i = 0; i < 499; i++)
        {
            Console.Write(sequenceNumberOne + ", " + sequenceNumberTwo + ", ");
            sequenceNumberOne += 2;
            sequenceNumberTwo -= 2;
        }
        Console.Write(sequenceNumberOne + ", " + sequenceNumberTwo + "\n");
        sequenceNumberOne += 2;
        sequenceNumberTwo -= 2;
    }
}
using System;
using System.IO;
class OddLines
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        using (reader)
        {
            int lineNumber = 1;
            string lineEven = reader.ReadLine();
            string lineOdd = reader.ReadLine();
            while (lineOdd != null && lineEven != null)
            {
                Console.WriteLine("Line {0}: {1}", lineNumber, lineOdd);
                lineEven = reader.ReadLine();
                lineOdd = reader.ReadLine();
                lineNumber += 2;
            }

        }
    }
}


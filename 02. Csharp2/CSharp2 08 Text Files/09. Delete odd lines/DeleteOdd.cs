using System;
using System.Collections.Generic;
using System.IO;
class DeleteOdd
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        var oddLines = new List<string>();
        using (reader)
        {
            int lineNumber = 1;
            string lineEven = reader.ReadLine();
            string lineOdd = reader.ReadLine();
            while (lineOdd != null && lineEven != null)
            {
                oddLines.Add(lineOdd);
                Console.WriteLine("Line {0}: {1}", lineNumber, lineOdd);
                lineEven = reader.ReadLine();
                lineOdd = reader.ReadLine();
                lineNumber += 2;
            }
        }
        StreamWriter writer = new StreamWriter("..\\..\\ProgramText.txt");
        using (writer)
        {
            foreach (var l in oddLines)
            {
                writer.WriteLine(l);
            }
        }
    }
}


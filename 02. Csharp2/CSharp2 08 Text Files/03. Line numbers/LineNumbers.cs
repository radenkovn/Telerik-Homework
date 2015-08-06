using System;
using System.IO;
class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        string text = reader.ReadLine();
        StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        int counter = 1;
        using (reader)
        {
            using (write)
            {
                while (text != null)
                {
                    
                    write.WriteLine("Line {0} - {1}", counter, text);
                    text = reader.ReadLine();
                    counter++;
                }
            }
        }

        StreamReader readerOutput = new StreamReader("..\\..\\Output.txt");
        using (readerOutput)
        {
            Console.WriteLine("Result");
            Console.WriteLine(readerOutput.ReadToEnd());
        }
    }
}


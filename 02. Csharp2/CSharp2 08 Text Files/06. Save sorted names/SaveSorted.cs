using System;
using System.Collections.Generic;
using System.IO;
class SaveSorted
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        string text = reader.ReadLine();
        StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        var names = new List<string>();  
        using (reader)
        {
            while (text != null)
            {

                names.Add(text);
                text = reader.ReadLine();
            }
        }

        names.Sort();


        using (write)
        {
            foreach (var n in names)
            {
                write.WriteLine(n);
                write.Flush();
            }
        }
        StreamReader readerOutput = new StreamReader("..\\..\\Output.txt");
        using (readerOutput)
        {
            Console.WriteLine("Result:\n");
            Console.WriteLine(readerOutput.ReadToEnd());
        }
    }
}


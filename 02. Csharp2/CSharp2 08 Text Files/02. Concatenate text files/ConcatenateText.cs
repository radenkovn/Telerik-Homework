
using System;
using System.IO;
class ConcatenateText
{
    static void Main()
    {
        StreamReader reader1 = new StreamReader("..\\..\\ProgramText1.txt");
        StreamReader reader2 = new StreamReader("..\\..\\ProgramText2.txt");
        string text1;
        string text2;
        using (reader1)
        {
            Console.WriteLine("File one");
            text1 = reader1.ReadToEnd();
            Console.WriteLine(text1);
        }
        using (reader2)
        {
            Console.WriteLine("File two");
            text2 = reader2.ReadToEnd();
            Console.WriteLine(text2);
        }
        StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        using (write)
        {
            write.WriteLine(text1);
            write.WriteLine(text2);
        }
        StreamReader readerOutput = new StreamReader("..\\..\\Output.txt");
        using (readerOutput)
        {
            Console.WriteLine("Result");
            Console.WriteLine(readerOutput.ReadToEnd());
        }
    }
}

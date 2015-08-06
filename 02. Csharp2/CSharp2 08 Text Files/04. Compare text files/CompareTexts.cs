using System;
using System.IO;

class CompareTexts
{
    static void Main()
    {
        StreamReader reader1File1 = new StreamReader("..\\..\\ProgramText1.txt");
        StreamReader reader1File2 = new StreamReader("..\\..\\ProgramText2.txt");

        int counter = 0;
        string textOne;
        string textTwo;
        using (reader1File1)
        {
            Console.WriteLine("File one");
            textOne = reader1File1.ReadToEnd();
            Console.WriteLine(textOne);
        }
        Console.WriteLine();
        using (reader1File2)
        {
            Console.WriteLine("File two");
            textTwo = reader1File2.ReadToEnd();
            Console.WriteLine(textTwo);
        }
        StreamReader reader2File1 = new StreamReader("..\\..\\ProgramText1.txt");
        StreamReader reader2File2 = new StreamReader("..\\..\\ProgramText2.txt");
        string line1 = reader2File1.ReadLine();
        string line2 = reader2File2.ReadLine();
        using (reader2File1)
        {
            using (reader2File2)
            {
                while (line1 != null)
                {
                    if (line1 == line2)
                    {
                        counter++;
                    }
                    line1 = reader2File1.ReadLine();
                    line2 = reader2File2.ReadLine();
                }
            }
        }
        Console.WriteLine("\nThere are {0} lines which are the same.\n",counter);
    }
}


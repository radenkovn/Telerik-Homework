//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.IO;
class WordCounter
{
    static void Main()
    {
       
        try
        {
            StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
            string text = reader.ReadToEnd();
            reader.Close();
            WordCount(text);
        }
        catch (Exception r)
        {
            Console.WriteLine("Error: {0}", r.Message);
        }
    }

    private static void WordCount(string text)
    {

        string[] checker = text.ToLower().Split(new char[] { ' ', '.', ',', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(checker);
        StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        using (write)
        {
            for (int i = 0; i < checker.Length; i++)
            {
                string current = checker[i];
                int count = 0;
                for (int j = i; j < checker.Length; j++)
                {
                    if (current != checker[j])
                    {
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                i = i + count - 1;
                write.WriteLine("{0,30} is present {1,2} times inside the text", current, count);


            }
        }

    }
}


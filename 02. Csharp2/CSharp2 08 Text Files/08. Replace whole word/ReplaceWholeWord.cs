using System;
using System.Collections.Generic;
using System.IO;
class ReplaceSubStr
{
    static void Main()
    {
        // First Method( add other special instances)
        Console.WriteLine("The file is 180 MB");
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace(" start ", " finish "));
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace(" start,", " finish,"));
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace(" start.", " finish."));
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace(" start!", " finish!"));
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace("Start ", "Finish "));

        Console.WriteLine("Finally done, check your file");
        // Alternative Method


        //StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        //string text = reader.ReadLine();
        //StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        //Console.WriteLine("This file is 180 MB");
        //using (reader)
        //{
        //    using (write)
        //    {
        //        while (text != null)
        //        {
        //            string first =  text.Replace(" start ", " finish ");
        //            string second = first.Replace        (" start,", " finish,");
        //            string third = second.Replace        (" start.", " finish.");
        //            string fourth = third.Replace        (" start!", " finish!");
        //            string writeThis = fourth.Replace    ("Start ", "Finish ");
        //            write.WriteLine(writeThis);
        //            write.Flush();
        //            text = reader.ReadLine();
        //        }
        //    }
        //}
        //Console.WriteLine("Done finally! Check the result in your program folder!");
    }
}


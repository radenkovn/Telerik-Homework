using System;
using System.Collections.Generic;
using System.IO;
class ReplaceSubStr
{
    static void Main()
    {
        // First Method
        File.WriteAllText("..\\..\\ProgramText.txt", File.ReadAllText("..\\..\\ProgramText.txt").Replace("start", "finish"));

        // Second Method

        //StreamReader reader = new StreamReader("..\\..\\ProgramText.txt");
        //string text = reader.ReadLine();
        //StreamWriter write = new StreamWriter("..\\..\\Output.txt");
        //Console.WriteLine("This file is 200 MB");
        //using (reader)
        //{
        //    using (write)
        //    {
        //        while (text != null)
        //        {
        //            string writeThis = text.Replace("start", "finish");
        //            write.WriteLine(writeThis);
        //            write.Flush();
        //            text = reader.ReadLine();
        //        }
        //    }
        //}
        //Console.WriteLine("Done finally! Check the result in your program folder!");
    }
}


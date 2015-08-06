//PROBLEM 14

using System;

class PrintAsciiTable
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 256; i++)
        {

            char c = (char)i;
            string PRINT = char.ConvertFromUtf32(c);
            Console.WriteLine("This is character number {0}, and it's corresponding symbol is : {1}", i, c);
        }
    }
}

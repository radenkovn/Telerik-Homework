﻿//PROBLEM 7

using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstString = @"The ""use"" of quotations causes difficulties.";
        string secondString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstString + "\n" + secondString);
    }
}


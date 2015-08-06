//PROBLEM 5:
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Linq;
using System.Collections.Generic;

//TWO WAYS WHICH I FOUND:
class SortStringLength
{
    static void Main()
    {

        string[] manyStrings = { "1234", "1234", "234", "1567872", "12334", "124434", "123424" };

        Array.Sort(manyStrings, (x1, x2) => x1.Length.CompareTo(x2.Length));

        //SortByLength(manyStrings); 

        Console.WriteLine(string.Join(", ", manyStrings));
    }

    //static IEnumerable<string> SortByLength(IEnumerable<string> e)
    //{
    //    // Use LINQ to sort the array received and return a copy.
    //    var sorted = from s in e
    //                 orderby s.Length ascending
    //                 select s;
    //    return sorted;
    //}


}


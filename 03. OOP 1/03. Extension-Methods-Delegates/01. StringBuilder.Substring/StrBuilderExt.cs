//PROPBLEM 1
//Implement an extension method Substring(int index, int length) for the class StringBuilder
//that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace StringBuilderSubstring
{
    using System;
    using System.Text;
    using StringBuilderSubstring.Extensions;
    class StrBuilderExt
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder(input);

            Console.WriteLine("StringBuilder.Substring: {0}", text.Substring(1, 5));
            Console.WriteLine("String.Substring:        {0}", input.Substring(1, 5));
           
        }
    }
}

//PROBLEM 17
//Write a program to return the string with maximum length from an array of strings.

namespace _17.Longest_String
{
    using System;
    using System.Linq;
    class LongestStr
    {
        public static void Main()
        {
            string[] myStrArr = { "hello", "hi", "hey", "well met", "good morning", "good evening", "good day" };
            string max = MaxOfStrings(myStrArr);
            Console.WriteLine("The longest string is: {0}",max);
        }
        public static string MaxOfStrings(string[] input)
        {
            // var max = input.FirstOrDefault(x=> x.Length == (input.Max(y => y.Length)));
            int maxLength = (from st in input
                             select st.Length).Max();

            var outputList = from st in input
                            where st.Length == maxLength
                            select st;
            var output = outputList.FirstOrDefault();
            return output;
        }
    }
}

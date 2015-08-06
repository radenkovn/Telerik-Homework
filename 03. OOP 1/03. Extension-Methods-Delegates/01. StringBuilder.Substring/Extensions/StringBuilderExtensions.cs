namespace StringBuilderSubstring.Extensions
{
    using System;
    using System.Text;
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                for (int i = index; i < index + length; i++)
                {

                    result.Append(input[i]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                
                return new StringBuilder("ERROR: The values you entered are out of range of the StringBuilder you provided");
            }
            return result;
        }
    }
}

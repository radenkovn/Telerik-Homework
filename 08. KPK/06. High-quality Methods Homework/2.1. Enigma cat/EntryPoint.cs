namespace EnigmaCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    class EntryPoint
    {
        public static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder();
            string[] inputText = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputText.Length; i++)
            {

                BigInteger currentNum = TextToDecimal(inputText[i]);
                output.Append(NumberToCat(currentNum).ToString() + " ");
            }
            Console.WriteLine(output.ToString().TrimEnd(' '));
        }

        public static StringBuilder NumberToCat(BigInteger input)
        {
            StringBuilder output = new StringBuilder();
            if (input == 0)
            {
                output.Append('a');
                return output;
            }
            BigInteger changer = input;
            char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            while (changer > 0)
            {
                int index = (int)(changer % 26);
                output.Insert(0, letters[index]);
                changer /= 26;
            }

            return output;
        }

        public static BigInteger TextToDecimal(string input)
        {
            BigInteger output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output += ((input[i] - 'a') * (BigInteger)Math.Pow(17, input.Length - i - 1));
            }
            return output;
        }
    }
}
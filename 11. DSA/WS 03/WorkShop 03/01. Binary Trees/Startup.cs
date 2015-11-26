namespace _01.Binary_Trees
{
    using System;
    using System.Numerics;

    public class Startup
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var n = input.Length;
            var colors = new int[26];

            foreach (var c in input)
            {
                colors[c - 'A']++;
            }

            var factorials = new BigInteger[2 * n + 1];
            factorials[0] = 1;

            for (int i = 0; i < 2 * n; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            var result = factorials[n];

            foreach (var f in colors)
            {
                result /= factorials[f];
            }
            var finalResult = factorials[2 * n];
            var nfacPlusOne = factorials[n + 1];
            var nfac = factorials[n];

            finalResult = finalResult / (nfacPlusOne * nfac);
            Console.WriteLine(result * finalResult);
        }
    }
}

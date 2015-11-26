using System;
using System.Collections.Generic;
using System.Linq;

namespace Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDenom = int.Parse(Console.ReadLine());
            var fraction = Console.ReadLine().Split('.')[1];

            int bestNom = 0;
            int bestDen = 1;
            int precision = 0;
            for (int den = 1; den <= maxDenom; den++)
            {
                int left = 0;
                int right = den;

                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (Compare(fraction, middle, den))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                int current = Divide(fraction, left - 1, den);
                if (current > precision)
                {
                    bestDen = den;
                    bestNom = left - 1;
                    precision = current;
                }

                current = Divide(fraction, left, den);
                if (current > precision)
                {
                    bestDen = den;
                    bestNom = left;
                    precision = current;
                }

            }
            Console.WriteLine("{0}/{1}", bestNom, bestDen);
            Console.WriteLine(precision + 1);
        }

        static int Divide(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }

                a = a % b * 10;
            }

            return i;
        }

        static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }

                a = a % b * 10;
            }

            return true;
        }
    }
}

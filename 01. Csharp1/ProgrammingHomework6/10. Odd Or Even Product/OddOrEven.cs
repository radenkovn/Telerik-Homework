//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.


using System;
using System.Numerics;
class OddOrEven
{
    static void Main()
    {
        string nIntegers = Console.ReadLine();
        string[] separated = nIntegers.Split(' ');
        BigInteger odd = 1;
        BigInteger even = 1;
        for (int i = 0; i < separated.Length; i++)
        {
            if ((i + 1) % 2 == 0)
            {
                even *= BigInteger.Parse(separated[i]);
            }
            else if ((i + 1) % 2 != 0)
            {
                odd *= BigInteger.Parse(separated[i]);
            }
        }
        bool isTrue = odd == even;
        if (isTrue)
        {
            Console.WriteLine("The product is {0}", odd);
            Console.WriteLine(isTrue);
        }
        else
        {
            Console.WriteLine("The even product is {0}, and the odd product is {1}", even, odd);
            Console.WriteLine(isTrue);
        }

    }
}


﻿//Extend the previous program to support also subtraction and multiplication of polynomials.

using System;
class AddPolynom
{
    static void Main()
    {
        Console.WriteLine("a*x^2 + b*x + c = 0");
        Console.Write("Enter a of the first polynomial: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b of the first polynomial: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c of the first polynomial: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter a of the second polynomial: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter b of the second polynomial: ");
        int e = int.Parse(Console.ReadLine());
        Console.Write("Enter c of the second polynomial: ");
        int f = int.Parse(Console.ReadLine());
        int[] polOne = { a, b, c };
        int[] polTwo = { d, e, f };
        PolSum(polOne, polTwo);
        PolSubt(polOne, polTwo);
        PolMult(polOne, polTwo);
    }

    static void PolSum(int[] polOne, int[] polTwo)
    {
        if (polOne[0] + polTwo[0] == 0 && polOne[1] + polTwo[1] == 0 && polOne[2] + polTwo[2] == 0)
        {
            Console.WriteLine("The result is an empty polynomial (0=0).");
            return;
        }
        Console.Write("The result of pol1 + pol2 is: ");
        for (int i = 0; i < 3; i++)
        {
            int sum = polOne[i] + polTwo[i];
            switch (i)
            {
                case 0:
                    {
                        Console.Write("{0}*x^2 + ", sum);
                        break;
                    }

                case 1:
                    {
                        Console.Write("{0}*x + ", sum);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("{0} = 0", sum);
                        break;
                    }
            }
        }
    }
    static void PolSubt(int[] polOne, int[] polTwo)
    {
        if (polOne[0] - polTwo[0] == 0 && polOne[1] - polTwo[1] == 0 && polOne[2] - polTwo[2] == 0)
        {
            Console.WriteLine("The result is an empty polynomial (0=0).");
            return;
        }
        Console.Write("The result of pol1 - pol2 is: ");
        for (int i = 0; i < 3; i++)
        {
            int subtr = polOne[i] - polTwo[i];
            switch (i)
            {
                case 0:
                    {
                        Console.Write("{0}*x^2 + ", subtr);
                        break;
                    }

                case 1:
                    {
                        Console.Write("{0}*x + ", subtr);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("{0} = 0", subtr);
                        break;
                    }
            }
        }
    }
    static void PolMult(int[] polOne, int[] polTwo)
    {
        if (polOne[0] * polTwo[0] == 0 && polOne[1] * polTwo[1] == 0 && polOne[2] * polTwo[2] == 0)
        {
            Console.WriteLine("The result is an empty polynomial (0=0).");
            return;
        }
        Console.Write("The result of pol1 * pol2 is: ");
        for (int i = 0; i < 3; i++)
        {
            int product = polOne[i] * polTwo[i];
            switch (i)
            {
                case 0:
                    {
                        Console.Write("{0}*x^2 + ", product);
                        break;
                    }

                case 1:
                    {
                        Console.Write("{0}*x + ", product);
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("{0} = 0", product);
                        break;
                    }
            }
        }
    }
}


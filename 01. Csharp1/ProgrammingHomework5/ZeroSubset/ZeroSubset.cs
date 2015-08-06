//PROBLEM 12

using System;

class ZeroSubset
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int fourthNumber = int.Parse(Console.ReadLine());
        int fifthNumber = int.Parse(Console.ReadLine());
        int[] all = { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber };
        bool zero = false;
        int sum;
        for (int i = 0; i < 5; i++)
        {
            for (int a = 0; a < 2; a++)
            {
                sum = all[i] * a;
                if (sum == 0 && a != 0)
                {
                    Console.WriteLine("{0} = 0", all[i]);
                    zero = true;
                }
                for (int j = i + 1; j < 5; j++)
                {
                    for (int b = 0; b < 2; b++)
                    {
                        sum = (all[i] * a) + (all[j] * b);
                        if (sum == 0 && (a != 0 && b != 0))
                        {
                            Console.WriteLine("{0} + {1} = 0", all[i], all[j]);
                            zero = true;
                        }
                        for (int k = j + 1; k < 5; k++)
                        {
                            for (int c = 0; c < 2; c++)
                            {
                                sum = (all[i] * a) + (all[j] * b) + (all[k] * c);
                                if (sum == 0 && (a != 0 && b != 0 && c != 0))
                                {
                                    Console.WriteLine("{0} + {1} + {2} = 0", all[i], all[j], all[k]);
                                    zero = true;
                                }
                                for (int l = k + 1; l < 5; l++)
                                {
                                    for (int d = 0; d < 2; d++)
                                    {
                                        sum = (all[i] * a) + (all[j] * b) + (all[k] * c) + (all[l] * d);
                                        if (sum == 0 && (a != 0 && b != 0 && c != 0 && d!=0))
                                        {
                                            Console.WriteLine("{0} + {1} + {2} + {3} = 0", all[i], all[j], all[k], all[l]);
                                            zero = true;
                                        }
                                        for (int m = l + 1; m < 5; m++)
                                        {
                                            for (int e = 0; e < 2; e++)
                                            {
                                                sum = (all[i] * a) + (all[j] * b) + (all[k] * c) + (all[l] * d) + (all[m] * e);
                                                if (sum == 0 && (a != 0 && b != 0 && c != 0 && d != 0 && e!=0))
                                                {
                                                    Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", all[i], all[j], all[k], all[l], all[e]);
                                                    zero = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (zero == false)
        {
            Console.WriteLine("no zero subset");
        }

    }
}


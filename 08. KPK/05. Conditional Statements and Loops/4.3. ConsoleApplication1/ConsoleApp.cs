namespace ConsoleApplication1
{
    using System;
    using System.Numerics;
    class ConsoleApp
    {
        static void Main()
        {
            string numbers = "";
            string command;
            int counter = 0;
            while (true)
            {
                command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else
                {
                    numbers += command + " ";
                    counter++;
                }
            }
            string[] divided = numbers.Split(' ');
            BigInteger[] integers = new BigInteger[counter];
            BigInteger result = 1;
            for (int i = 0; i < counter; i++)
            {
                integers[i] = BigInteger.Parse(divided[i]);
            }
            if (counter <= 10)
            {
                for (int i = 0; i < counter; i++)
                {
                    if (i % 2 != 0)
                    {
                        BigInteger changer = integers[i];
                        int digit;
                        int product = 1;
                        if (changer > 0)
                        {
                            while (changer > 0)
                            {
                                digit = (int)(changer % 10);
                                changer /= 10;
                                if (digit != 0)
                                {
                                    product *= digit;
                                }
                            }
                        }
                        else if (changer == 0)
                        {
                            product = 1;
                        }
                        result *= product;
                    }
                }
                Console.WriteLine(result);
            }
            else if (counter > 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        BigInteger changer = integers[i];
                        int digit;
                        int product = 1;
                        if (changer > 0)
                        {
                            while (changer > 0)
                            {
                                digit = (int)(changer % 10);
                                changer /= 10;
                                if (digit != 0)
                                {
                                    product *= digit;
                                }
                            }
                        }
                        else if (changer == 0)
                        {
                            product = 1;
                        }
                        result *= product;
                    }
                }
                Console.WriteLine(result);
                result = 1;
                for (int i = 10; i < counter; i++)
                {
                    if (i % 2 != 0)
                    {
                        BigInteger changer = integers[i];
                        int digit;
                        int product = 1;
                        if (changer > 0)
                        {
                            while (changer > 0)
                            {
                                digit = (int)(changer % 10);
                                changer /= 10;
                                if (digit != 0)
                                {
                                    product *= digit;
                                }
                            }
                        }
                        else if (changer == 0)
                        {
                            product = 1;
                        }
                        result *= product;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
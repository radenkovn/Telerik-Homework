//PROBLEM 7

using System;

namespace SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            double max = double.Parse(Console.ReadLine());
            double middle = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());
            double temp;
            if (max < middle)
            {
                temp = max;
                max = middle;
                middle = temp;
                if (middle < min)
                {
                    temp = middle;
                    middle = min;
                    min = temp;
                    if (max < middle)
                    {
                        temp = max;
                        max = middle;
                        middle = temp;
                    }
                }
            }
            else if (middle < min)
            {
                temp = middle;
                middle = min;
                min = temp;
                if (max < middle)
                {
                    temp = max;
                    max = middle;
                    middle = temp;
                }
            }
            Console.WriteLine("{0} {1} {2}", max, middle, min);
        }
    }
}

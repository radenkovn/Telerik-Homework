namespace MethodPrintStatistics
{
    using System;

    class EntryPoint
    {
        static void Main()
        {
            double[] testNumbers = new double[] { 1, 5, 2, 15, 14, 25, 22 };
            int count = 5;
            PrintStatistics(testNumbers, count);
        }

        public static void PrintStatistics(double[] numbers, int count)
        {
            PrintMax(numbers, count);
            PrintMin(numbers, count);
            PrintAvg(numbers, count);
        }

        public static void PrintMax(double[] numbers, int count)
        {
            double max = Double.MinValue;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine(max);
        }

        public static void PrintMin(double[] numbers, int count)
        {
            double min = Double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            Console.WriteLine(min);
        }

        public static void PrintAvg(double[] numbers, int count)
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            double average = sum / count;
            Console.WriteLine(average);
        }
    }

}
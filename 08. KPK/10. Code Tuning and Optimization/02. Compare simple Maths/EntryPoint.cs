//Write a program to compare the performance of:
//    add, subtract, increment, multiply, divide
//for the values:
//    int, long, float, double and decimal


namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    class EntryPoint
    {
        static void Main()
        {


            int integerTester = 1;
            long longTester = 1;
            float floatTester = 1;
            double doubleTester = 1;
            decimal decimalTester = 1;
            TestAddition(integerTester, longTester, floatTester, doubleTester, decimalTester);
            TestSubtraction(integerTester, longTester, floatTester, doubleTester, decimalTester);
            TestIncrement(integerTester, longTester, floatTester, doubleTester, decimalTester);
            TestMultiplication(integerTester, longTester, floatTester, doubleTester, decimalTester);
            TestDivision(integerTester, longTester, floatTester, doubleTester, decimalTester);
            Console.WriteLine("\n\n---------------------------------------------");
            Console.WriteLine("CONCLUSION: DECIMAL IS THE SLOWEST");


        }
        static void TestAddition(int integerTester, long longTester, float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing ADDITION :\n-------------------------------- ");
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                integerTester += i;
            }

            stopwatch.Stop();
            Console.WriteLine("Integer: {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (long i = 0; i < 1000; i++)
            {
                longTester += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long:    {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (float i = 0; i < 1000; i++)
            {
                floatTester += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester += i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestSubtraction(int integerTester, long longTester, float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Subtraction :\n-------------------------------- ");
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                integerTester -= i;
            }

            stopwatch.Stop();
            Console.WriteLine("Integer: {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (long i = 0; i < 1000; i++)
            {
                longTester -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long:    {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (float i = 0; i < 1000; i++)
            {
                floatTester -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester -= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestIncrement(int integerTester, long longTester, float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Increment :\n-------------------------------- ");
            stopwatch.Start();

            for (int i = 0; i < 1000; i++)
            {
                integerTester++;
            }

            stopwatch.Stop();
            Console.WriteLine("Integer: {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (long i = 0; i < 1000; i++)
            {
                longTester++;
            }
            stopwatch.Stop();
            Console.WriteLine("Long:    {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (float i = 0; i < 1000; i++)
            {
                floatTester++;
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester++;
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester++;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestMultiplication(int integerTester, long longTester, float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Multiplication :\n-------------------------------- ");
            stopwatch.Start();

            for (int i = 0; i < 50; i++)
            {
                integerTester *= i;
            }

            stopwatch.Stop();
            Console.WriteLine("Integer: {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (long i = 0; i < 50; i++)
            {
                longTester *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long:    {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (float i = 0; i < 50; i++)
            {
                floatTester *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 50; i++)
            {
                doubleTester *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 50; i++)
            {
                decimalTester *= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestDivision(int integerTester, long longTester, float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Division :\n-------------------------------- ");
            stopwatch.Start();

            for (int i = 1; i < 50; i++)
            {
                integerTester /= i;
            }

            stopwatch.Stop();
            Console.WriteLine("Integer: {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (long i = 1; i < 50; i++)
            {
                longTester /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Long:    {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (float i = 1; i < 50; i++)
            {
                floatTester /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 1; i < 50; i++)
            {
                doubleTester /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 1; i < 50; i++)
            {
                decimalTester /= i;
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }
    }
}

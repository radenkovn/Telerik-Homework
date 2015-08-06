//Write a program to compare the performance of:
//    square root, natural logarithm, sinus
//for the values:
//    float, double and decimal


namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;
    class EntryPoint
    {
        static void Main()
        {
            float floatTester = 5000.5555f;
            double doubleTester= 5000.5555;
            decimal decimalTester= 5000.5555m;
            TestSQRT(floatTester, doubleTester, decimalTester);
            TestLogarithm(floatTester, doubleTester, decimalTester);
            TestSine(floatTester, doubleTester, decimalTester);
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine("DOUBLE IS THE FASTEST, DECIMAL IS THE SLOWEST");
        }
        static void TestSQRT(float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing ADDITION :\n-------------------------------- ");
            stopwatch.Start();
            for (float i = 0; i < 1000; i++)
            {
                floatTester = (float)Math.Sqrt(floatTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester = Math.Sqrt(doubleTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester = (decimal)Math.Sqrt((double)decimalTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestLogarithm(float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Logarithm :\n-------------------------------- ");
            stopwatch.Start();
            for (float i = 0; i < 1000; i++)
            {
                floatTester = (float)Math.Log(floatTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester = Math.Log(doubleTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester = 5000.5m;
                decimalTester = (decimal)Math.Log((double)decimalTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }

        static void TestSine(float floatTester, double doubleTester, decimal decimalTester)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Testing Sine :\n-------------------------------- ");
            stopwatch.Start();
            for (float i = 0; i < 1000; i++)
            {
                floatTester = (float)Math.Sin(floatTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Float:   {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (double i = 0; i < 1000; i++)
            {
                doubleTester = Math.Sin(doubleTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Double:  {0,20}", stopwatch.Elapsed);
            stopwatch.Restart();

            for (decimal i = 0; i < 1000; i++)
            {
                decimalTester = (decimal)Math.Sin((double)decimalTester);
            }
            stopwatch.Stop();
            Console.WriteLine("Decimal: {0,20}", stopwatch.Elapsed);
        }
    }
}

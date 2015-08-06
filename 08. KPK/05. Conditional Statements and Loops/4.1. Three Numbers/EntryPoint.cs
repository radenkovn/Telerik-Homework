namespace ThreeNumbers
{
    using System;
    class EntryPoint
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            double maxNumber = firstNumber;
            if (maxNumber < secondNumber)
            {
                maxNumber = secondNumber;
            }
            if (maxNumber < thirdNumber)
            {
                maxNumber = thirdNumber;
            }

            double minNumber = firstNumber;
            if (minNumber > secondNumber)
            {
                minNumber = secondNumber;
            }
            if (minNumber > thirdNumber)
            {
                minNumber = thirdNumber;
            }
            double sum = firstNumber + secondNumber + thirdNumber;
            double averageValue = (sum) / 3;
            Console.WriteLine(maxNumber);
            Console.WriteLine(minNumber);
            var printFormat = "{0:0.00}";
            Console.WriteLine(printFormat, averageValue);
        }
    }
}

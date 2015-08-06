namespace SearchInBits
{
    using System;

    class Bits
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int inputLines = int.Parse(Console.ReadLine());
            string numberAsBit = Convert.ToString(inputNumber, 2).PadLeft(4, '0');
            char fourthSymbol = numberAsBit[(numberAsBit.Length - 1)];
            char thirdSymbol = numberAsBit[(numberAsBit.Length - 2)];
            char secondSymbol = numberAsBit[(numberAsBit.Length - 3)];
            char firstSymbol = numberAsBit[(numberAsBit.Length - 4)];

            int foundCount = 0;
            for (int i = 0; i < inputLines; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string currentNumberAsBit = Convert.ToString(currentNumber, 2).PadLeft(30, '0');
                for (int j = 0; j < currentNumberAsBit.Length - 3; j++)
                {
                    var sameFirstSymbol = currentNumberAsBit[j] == firstSymbol;
                    var sameSecondSymbol = currentNumberAsBit[j + 1] == secondSymbol;
                    var sameThirdSymbol = currentNumberAsBit[j + 2] == thirdSymbol;
                    var sameFourthSymbol = currentNumberAsBit[j + 3] == fourthSymbol;
                    var isFound = sameFirstSymbol && sameSecondSymbol && sameThirdSymbol && sameFourthSymbol;
                    if (isFound)
                    {
                        foundCount++;
                    }
                }
            }

            Console.WriteLine(foundCount);
        }
    }
}
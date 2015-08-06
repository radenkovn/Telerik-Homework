namespace Decoding
{
    using System;
    class Decoding
    {
        static void Main()
        {
            int decodingNumber = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            for (int i = 0; i < inputText.Length; i++)
            {
                var currentSymbol = inputText[i];
                double decodedResult = 0;
                var symbolIsNumber = inputText[i] == '1' || inputText[i] == '2' || inputText[i] == '3' || inputText[i] == '4' || inputText[i] == '5' || inputText[i] == '6' || inputText[i] == '7' || inputText[i] == '8' || inputText[i] == '9' || inputText[i] == '0';
                var symbolIsEndSymbol = currentSymbol == '@';
                var symbolIsLetter = ((int)currentSymbol >= 97 && (int)currentSymbol <= 122) || ((int)currentSymbol >= 65 && (int)currentSymbol <= 90);
                if (symbolIsNumber)
                {
                    decodedResult = (int)currentSymbol + decodingNumber + 500;
                }
                else if (symbolIsEndSymbol)
                {
                    break;
                }
                else if (symbolIsLetter)
                {
                    decodedResult = ((int)currentSymbol * decodingNumber) + 1000;
                }
                else
                {
                    decodedResult = (int)currentSymbol - decodingNumber;
                }

                if ((i) % 2 == 0)
                {
                    decodedResult = decodedResult / 100.0;
                    var printFormat = "{0:0.00}";
                    Console.WriteLine(printFormat, decodedResult);
                }
                else if ((i) % 2 != 0)
                {
                    decodedResult = decodedResult * 100;
                    Console.WriteLine(decodedResult);
                }
            }
        }
    }

}
//PROBLEM 1

using System;


class ExchangeIfGreater
{
    static void Main()
    {

        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double temp = secondNumber;
        if (firstNumber > secondNumber)
        {
            secondNumber = firstNumber;
            firstNumber = temp;
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        else
        {  
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}


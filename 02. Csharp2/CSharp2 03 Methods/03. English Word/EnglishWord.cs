//Write a method that returns the last digit of given integer as an English word.

using System;

class EnglishWord
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        string lastDigit = English(number);
        Console.WriteLine("The last digit of your number is {0}.", lastDigit);
    }

    static string English(int number)
    {
        string word;
        int digit = number % 10;
        switch (digit)
        {
            case 0: word= "zero"; break;
            case 1: word = "one"; break;
            case 2: word = "two"; break;
            case 3: word = "three"; break;
            case 4: word = "four"; break;
            case 5: word = "five"; break;
            case 6: word = "six"; break;
            case 7: word = "seven"; break;
            case 8: word = "eight"; break;
            case 9: word = "nine"; break;
            default: word = "Not found!"; break;
        }
        return word;
    }
}


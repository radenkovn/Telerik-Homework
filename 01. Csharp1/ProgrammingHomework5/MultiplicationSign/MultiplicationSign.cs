using System;


class MultiplicationSign
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber= double.Parse(Console.ReadLine());
        string result;
        int counter =0;
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            result = "0";
            Console.WriteLine(result);
        }
        else
        {
            if (firstNumber < 0)
            {
                counter++;
            }
            if (secondNumber < 0)
            {
                counter++;
            }
            if (thirdNumber < 0)
            {
                counter++;
            }
            if (counter %2 != 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}


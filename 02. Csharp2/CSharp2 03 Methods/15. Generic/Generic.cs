//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).


using System;
class IntCalcs
{
    static void Main()
    {
        int length;
        do
        {
            Console.Write("Enter the ammount of numbers you want to use: ");
            length = int.Parse(Console.ReadLine());
        }
        while (length <= 0);

        // YOU CAN CHANGE THE TYPE TO ANYTHING YOU WANT TO, just change the type if you want to test it:"
        double[] numbers = new double[length];
        //type                 type
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
            //           type
        }


        AvgSeq(numbers);
        Max(numbers);
        Min(numbers);
        Sum(numbers);
        Product(numbers);


    }
    static void Max<T>(T[] numbers)
        where T : IComparable<T>
    {
        T max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(max) > 0)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("The MAX out of the numbers is {0}.", max);
    }
    static void Min<T>(T[] numbers)
        where T : IComparable<T>
    {
        T min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i].CompareTo(min) < 0)
            {
                min = numbers[i];
            }
        }
        Console.WriteLine("The MIN out of the numbers is {0}.", min);
    }
    static void AvgSeq<T>(T[] numbers)
        where T : IComparable<T>
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += double.Parse(numbers[i].ToString());
        }
        double avg = sum / numbers.Length;
        Console.WriteLine("The AVERAGE sum of the numbers is {0:0.00}.", avg);
    }
    static void Sum<T>(T[] numbers)
        where T : IComparable<T>
    {
        double sum = 0;
        foreach (T number in numbers)
        {
            sum += double.Parse(number.ToString());
        }
        Console.WriteLine("The SUM of the numbers is {0}.", sum);
    }
    static void Product<T>(T[] numbers)
        where T : IComparable<T>
    {
        double product = 1;
        foreach (T number in numbers)
        {
            product *= double.Parse(number.ToString());
        }
        Console.WriteLine("The PRODUCT of the numbers is {0}.", product);
    }
}


//Write a program that reads an integer number and calculates and prints its square root.
//    If the number is invalid or negative, print Invalid number.
//    In all cases finally print Good bye.
//Use try-catch-finally block.


using System;
class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        try
        {
            int number = int.Parse(Console.ReadLine());
            double root = Math.Sqrt(number);
            if (double.IsNaN(root))
            {
                throw new ArgumentNullException();
            }
            Console.WriteLine("Its square root is {0:0.00}",root);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Error: The number is less than zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: You have not entered a number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value overflowed");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}


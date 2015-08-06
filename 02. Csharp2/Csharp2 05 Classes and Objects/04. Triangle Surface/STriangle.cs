//Write methods that calculate the surface of a triangle by given:
//    Side and an altitude to it;
//    Three sides;
//    Two sides and an angle between them;
//Use System.Math.

//input 	                        output
//* a = 23.2,   h = 5 	            58
//* a = 11,     b =12,  c = 13 	    61.48
//* a = 10,     b = 7,  C = 25°  	14.79


using System;
class STriangle
{
    static void Main()
    {
        Console.WriteLine("Enter 1 if you want to calculate S by using 3 sides.\nEnter 2 if you want to calculate S by using a side and an altitude.\nEnter 3 if you want to calculate S by using 2 sides and an angle.");
        Console.Write("Enter your choice here: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                {

                    Console.WriteLine("You chose the 3 sides method: ");
                    Console.Write("Enter side one: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter side two: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter side three: ");
                    double c = double.Parse(Console.ReadLine());
                    try
                    {
                        double s = SBySides(a, b, c);
                        Console.WriteLine("The area of the triangle is {0}", s);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The sides of the triangle should be more than 0!");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("What you entered is not a real triangle!");
                    }

                    break;
                }

            case 2:
                {
                    Console.WriteLine("You chose the side and altitude method: ");
                    Console.Write("Enter the side: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter the altitude: ");
                    double h = double.Parse(Console.ReadLine());
                    try
                    {
                        double s = SByAltitude(a, h);
                        Console.WriteLine("The area is equal to {0:0.00}.", s);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The side and altitude should be more than 0!");
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("You chose the 2 sides and an angle method: ");
                    Console.Write("Enter side one: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("Enter side two: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.Write("Enter the angle between them: ");
                    double alpha = double.Parse(Console.ReadLine());
                    try
                    {
                        double s = SbyAngle(a, b, alpha);
                        Console.WriteLine("The area is equal to {0:0.00}.", s);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The two sides should be more than 0!");
                    }
                    catch (ArgumentNullException)
                    {
                        Console.WriteLine("The angle should be between 1 and 179!");
                    }
                    break;
                }
            default: Console.WriteLine("Your choice should be between 1 and 3!");
                break;
        }
    }

    static double SBySides(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
        {
            throw new ArgumentNullException();
        }
        double p = (sideA + sideB + sideC) / 2;
        double s = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        return s;
    }

    static double SByAltitude(double side, double altitude)
    {
        if (side <= 0 || altitude <= 0 )
        {
            throw new ArgumentOutOfRangeException();
        }
        double s = side * altitude / 2;
        return s;
    }
    static double SbyAngle(double sideA, double sideB, double angle)
    {
        if (sideA <= 0 || sideB <= 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (angle <= 0 || angle >= 180)
        {
            throw new ArgumentNullException();
        }
        double s = sideA * sideB * Math.Sin(angle) / 2;
        return s;
    }

}


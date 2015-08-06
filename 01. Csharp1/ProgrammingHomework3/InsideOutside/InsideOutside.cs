// PROBLEM 10
// INSIDE K({1, 1}, 1.5)
// OUTSIDE R(top=1, left=-1, width=6, height=2).
using System;


class InsideOutside
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double circleX;
        double circleY;
        bool insideCircle = false;
        bool outsideRectangle = !(x < -1 || x > 5) && (y < -1 || y > 1);
        for (int i = 0; i < 180; i++)
        {
                circleX = ((Math.Cos(Math.PI * i / 180) * 1.5) + 1);// These are all the possible points in the circle with a 1 degree accuracy.
                circleY = ((Math.Sin(Math.PI * i / 180) * 1.5) + 1);// *1.5, because the radius is 1.5 instead of 1. + 1, because the center of the circle was moved to 1,1 from 0,0.
                if (circleX >= 0 && circleY >= 0)
                {
                    if (x <= circleX && y <= circleY)
                    {
                        insideCircle = true;
                    }
                }
                if (circleX <= 0 && circleY <= 0)
                {
                    if (x >= circleX && y >= circleY)
                    {
                        insideCircle = true;
                    }
                }
            
        }
        if (insideCircle && outsideRectangle)
        {
            Console.WriteLine("It is inside the circle and outside the rectangle!");
        }
        else
        {
            Console.WriteLine("It is not inside the circle or outside the rectangle!");
        }
    }
}


//PROBLEM 2

using System;


class MoonGravity
{
    static void Main()
    {

        float weightEarth = float.Parse(Console.ReadLine());
        float weightMoon = weightEarth * 0.17f;
        Console.WriteLine("Your weight on the MOon is {0}", weightMoon);
    }
}


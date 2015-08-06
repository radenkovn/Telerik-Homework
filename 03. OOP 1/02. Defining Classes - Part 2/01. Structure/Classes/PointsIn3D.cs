//Problem 3
namespace Structure
{
    using System;
    public static class PointsIn3D
    {
        public static string Distance(Point3D first, Point3D second)
        {
            double distance = Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2) + Math.Pow((first.Z - second.Z), 2));
            return string.Format("The distance between {0} and {1} is {2:0.00}", first, second, distance);
        }
    }
}

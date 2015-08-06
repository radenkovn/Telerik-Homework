﻿namespace CohesionAndCoupling.Classes
{
    using System;
    static class DistanceCalculator
    {
        public static double CalcDistance2D(double x1, double y1, double x2 = 0, double y2 = 0)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalcDistance3D(double x1, double y1, double z1, double x2 = 0, double y2 = 0, double z2 = 0)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }
    }
}

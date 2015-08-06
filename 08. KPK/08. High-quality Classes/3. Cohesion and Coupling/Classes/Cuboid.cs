namespace CohesionAndCoupling.Classes
{
    using System;

    class Cuboid
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }
        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = DistanceCalculator.CalcDistance3D(Width, Height, Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = DistanceCalculator.CalcDistance2D(Width, Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = DistanceCalculator.CalcDistance2D(Width, Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = DistanceCalculator.CalcDistance2D(Height, Depth);
            return distance;
        }
    }
}

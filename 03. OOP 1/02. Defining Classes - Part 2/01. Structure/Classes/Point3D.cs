namespace Structure
{
    public struct Point3D
    {
        //Problem 2
        private static readonly Point3D start = new Point3D(0, 0, 0);
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        //Problem 2
        public static Point3D O { get { return Point3D.start; } }
        //Problem 1
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}

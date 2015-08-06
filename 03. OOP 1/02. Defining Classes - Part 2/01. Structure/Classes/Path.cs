//Problem 4
namespace Structure
{
    using System.Collections.Generic;
    class Path
    {
        private static Point3D[] sequencePoints = { new Point3D(4.4, 123, 238.5),
                                                    new Point3D(1.2, 5345, 2.5),
                                                    new Point3D(23.1, 42, 23.51),
                                                    new Point3D(59.2, 484, 59.2), 
                                       };
        public static Point3D[] SequencePoints { get { return Path.sequencePoints; } }
    }
}

namespace Structure
{
    using System;
    class MainProgram
    {
        static void Main()
        {
            Point3D pointOne = new Point3D(4, 5.2, 6);
            Point3D pointTwo = new Point3D(15, 5, 23);

            Console.WriteLine(PointsIn3D.Distance(pointOne, pointTwo));

            Console.WriteLine("\nTesting ToString\n");

            System.Console.WriteLine(pointOne);

            Console.WriteLine("\nTesting foreach for the Path\n");
            foreach (var item in Path.SequencePoints)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nThe items in the Path Storage:\n");

            foreach (var item in PathStorage.StorageComponents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nTest whatever you want!");
        }
    }
}

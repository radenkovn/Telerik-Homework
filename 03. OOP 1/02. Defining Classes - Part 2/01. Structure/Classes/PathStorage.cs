//Problem 4
namespace Structure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public static class PathStorage
    {
        private static List<Point3D> storageComponents;
        static PathStorage()
        {
            List<Point3D> currentList = new List<Point3D>();
            StreamReader reader = new StreamReader("..\\..\\Storage.txt");
            string line = reader.ReadLine();

            using (reader)
            {
                while (line != null)
                {
                    
                    string[] currentLine =  line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    Point3D currentPoint = new Point3D(double.Parse(currentLine[0]), double.Parse(currentLine[0]), double.Parse(currentLine[2]));
                    currentList.Add(currentPoint);
                    line = reader.ReadLine();
                }
            }
            PathStorage.storageComponents = currentList;
        }
        public static List<Point3D> StorageComponents { get { return PathStorage.storageComponents; } }

    }
}

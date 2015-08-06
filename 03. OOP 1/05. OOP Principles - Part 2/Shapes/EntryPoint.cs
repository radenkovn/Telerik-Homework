namespace Shapes
{
    using System;
    using Shapes.Classes;
    public class EntryPoint
    {
        public static void Main()
        {
            Shape[] manyShapes = new Shape[5];
            manyShapes[0] = new Rectanle(5.3, 13.2);
            manyShapes[1] = new Triangle(12.3, 45.25);
            manyShapes[2] = new Square(82.3);
            manyShapes[3] = new Triangle(45.2, 11.7);
            manyShapes[4] = new Rectanle(5.5, 10.2);
            foreach (var shape in manyShapes)
            {
                Console.WriteLine("The surface of {0} is equal to {1:0.00}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}

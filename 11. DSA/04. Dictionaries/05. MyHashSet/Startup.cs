namespace MyHashSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MyHashTable;

    public class Startup
    {
        static void Main()
        {
            var setOne = new Set<int>();
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(5);
            setOne.Add(6);

            var setTwo = new Set<int>();
            setTwo.Add(5);
            setTwo.Add(10);

            Console.WriteLine(setOne);
            Console.WriteLine(setTwo);

            var union = setOne.Union(setTwo);

            Console.WriteLine();
            Console.WriteLine(union);

            var intersect = setOne.Intersect(setTwo);

            Console.WriteLine(intersect);
        }
    }
}

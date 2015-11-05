namespace MyHashTable
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var table = new HashTable<int, int>();

            table.Add(1, 11);
            table.Add(2, 12);
            table.Add(3, 13);
            table.Add(4, 14);
            table.Add(5, 15);
            table.Add(6, 16);
            table.Add(7, 17);
            table.Add(8, 18);
            //var four = table.Find(4);
            Console.WriteLine();
            Console.WriteLine(table.Count);
            table.Remove(4);
            table.Remove(4);
            Console.WriteLine();
            Console.WriteLine(table.Count);
            Console.WriteLine();
            var secondfour = table.Find(4);
            Console.WriteLine(table.Count);
            Console.WriteLine(secondfour);
            Console.WriteLine(table[1]);
            table[1] = 15;
            Console.WriteLine(table[1]);
            Console.WriteLine(string.Join(", ", table.Keys));


        }
    }
}

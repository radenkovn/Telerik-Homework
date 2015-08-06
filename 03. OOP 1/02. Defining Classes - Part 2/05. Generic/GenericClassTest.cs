namespace Generic
{
    using System;
    class GenericClassTest
    {
        static void Main()
        {
            var newList = new GenericList<int>();
            for (int i = 0; i < 5; i++)
            {
                newList.Add(i);
            }
            newList.Remove(3);
            newList.Insert(3, 3);
            Console.WriteLine("For each");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Index of");
            Console.WriteLine(newList.IndexOf(2));
            Console.WriteLine();
            Console.WriteLine("ToString");
            Console.WriteLine(newList);
            Console.WriteLine();
            Console.WriteLine("Min");
            Console.WriteLine(newList.Min());
            Console.WriteLine();
            Console.WriteLine("Max");
            Console.WriteLine(newList.Max());
            newList.Clear();
            Console.WriteLine("After clear");
            Console.WriteLine(newList);
            Console.WriteLine("Test whatever you want!");

        }
    }

}

//Problem 2
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
namespace IEnumerableExtProg
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using IEnumerableExtProg.Extensions;
    class IEnumExt
    {
        static void Main()
        {
            List<int> mytestList = new List<int>();
            for (int i = 1; i < 10; i++)
			{
                mytestList.Add(i);
			}
            Console.WriteLine("Sum: {0}", mytestList.Sum());
            Console.WriteLine("Product: {0}", mytestList.Product());
            Console.WriteLine("Average: {0}", mytestList.MyAvg());
            Console.WriteLine("Min: {0}", mytestList.MyMin());
            Console.WriteLine("mMx: {0}", mytestList.MyMax());
        }
    }
}

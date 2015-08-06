//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
//Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

namespace _06.Divisible_by_7_and_3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class DivBy7and3
    {
        static void Main()
        {
            int[] arrInts = { 4, 15, 123, 23, 15, 123, 23, 239, 49, 63, 25, 44, 45, 90 };
            var divInts = arrInts.Where(x => (x % 3 == 0 || x % 7 == 0));
            Console.WriteLine("Divisible by 7 or 3");
            foreach (var item in divInts)
            {
                Console.WriteLine(item);
            }
            var divIntsQuery = from n in arrInts
                               where (n % 3 == 0 || n % 7 == 0)
                               select n;
            Console.WriteLine("Divisible by 7 or 3 by using linq query");
            foreach (var item in divIntsQuery)
            {
                Console.WriteLine(item);
            }
        }
    }
}

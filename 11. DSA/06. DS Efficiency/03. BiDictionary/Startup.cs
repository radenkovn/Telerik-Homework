using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BiDictionary
{
    public class Startup
    {
        static void Main()
        {
            var dict = new BiDictionary<int, string, int>();

            dict.Add(25, "10", 1);
            dict.Add(25, "5", 2);
            dict.Add(15, "3", 3);
            dict.Add(15, "1", 4);
            dict.Add(15, "2", 5);
            dict.Add(12, "10", 5);
            dict.Add(25, "10", 6);
            dict.Add(12, "10", 7);
            dict.Add(25, "10", 8);

            Console.WriteLine("First Dictionary");
            Console.WriteLine(dict[5]);
            Console.WriteLine(dict[25]);
            Console.WriteLine(dict[15]);
            Console.WriteLine(dict["10"]);
            Console.WriteLine("{{{0}}}", string.Join(",", dict[25, "10"]));

            var dict2 = new BiDictionary<int, int, int>();
            dict2.Add(25, 10, 1);
            dict2.Add(25, 10, 1);
            dict2.Add(25, 10, 1);
            dict2.Add(25, 10, 2);
            dict2.Add(25, 10, 2);
            Console.WriteLine("Second Dictionary");

            //This cannot be called because both keys are ints
            //Console.WriteLine(dict2[25]);
            Console.WriteLine("{{{0}}}", string.Join(",", dict2[25, 10]));

        }
    }
}
